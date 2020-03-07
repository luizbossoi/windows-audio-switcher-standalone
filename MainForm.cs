/*

    WINDOWS AUDIO SWITCHER - BY PROCESS
    This software was developed by LuizBossoi under MIT License
    ------------------------------------------------------------

    This software listen for a specific process and when matched, it changes the default audio output on your computer.
    .NET Framework required. Tested on Windows 10;
*/

using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;


namespace WindowsAudioSwitcher
{
    public partial class MainForm : Form
    {

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public audioDevice audioDevice;
        public List<audioDevice> audioDevicesList;
        public List<String> processes;
        public PolicyConfigClient client;
        public String lastProcess = "";
        public bool deviceChanged = false;

        public bool changedProcess = false;
        public bool changedDefault = true;

        public MainForm()
        {

            if (!Directory.Exists("settings"))
            {
                Directory.CreateDirectory("./settings");
            }

            InitializeComponent();
            enumerateAudioDevices();
            populateAudioDefault();
            loadSavedSettings();            
        }
  

        private void loadSavedMainSettings()
        {
            var inifile = new IniFile(@"config.ini");
            
            String defaultaudio = inifile.Read("DefaultAudio", "CONFIG");
            String startonboot = inifile.Read("StartOnBoot", "CONFIG");

            
            comboDefaultAudio.SelectedIndex = comboDefaultAudio.FindString(defaultaudio);
            if (startonboot.IndexOf("True")>-1) { chk_startonboot.Checked = true; } else { chk_startonboot.Checked = false; }
        }

        private void loadSavedSettings()
        {
            String[] filelist = Directory.GetFiles("settings");
            listSettings.Items.Clear();

            foreach(String f in filelist)
            {
                listSettings.Items.Add(Path.GetFileName(f).Replace(".ini", ""));
            }
        }
        private void SetStartup(bool setting)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (setting)
                rk.SetValue(MainForm.ActiveForm.Text, Application.ExecutablePath);
            else
                rk.DeleteValue(MainForm.ActiveForm.Text, false);

        }
        private void loadSetting(String filename)
        {
            listProcesses.Items.Clear();
            populateProcesses();
            populateAudioSettings();
            var inifile = new IniFile("settings\\" + filename + ".ini");
            String process = inifile.Read("Process", "AUDIOSETTING");
            String audiodevice = inifile.Read("AudioDevice", "AUDIOSETTING");

            // select item
            if(listProcesses.FindString(process)>-1)
            {
                listProcesses.SetSelected(listProcesses.FindString(process), true);
            } else
            {
                listProcesses.Items.Add(process);
            }

            // select device
            if(comboSettingAudioDevice.FindString(audiodevice)>-1)
            {
                comboSettingAudioDevice.SelectedIndex = comboSettingAudioDevice.FindString(audiodevice);
            }
            
        }

        public string getActiveProcess()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            try
            {
                return Path.GetFileName(p.MainModule.FileName);
            } catch(Exception)
            {

                // in case of access denied, 
                try
                {
                    return p.ProcessName;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        public void enumerateAudioDevices()
        {
            client = new PolicyConfigClient();
            var enumerator = new MMDeviceEnumerator();
            audioDevicesList = new List<audioDevice>();

            // clear the list
            audioDevicesList.Clear();
            
            foreach (var endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)) {
                audioDevicesList.Add(new audioDevice(endpoint.FriendlyName, endpoint.ID));
            }
        }

        public void setDefaultAudioOutput(String ID)
        {
            client = new PolicyConfigClient();

            // check if current audio differs from new
            var enumerator = new MMDeviceEnumerator();
            if(!enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console).ID.Equals(ID))
            {
                client.SetDefaultEndpoint(ID, Role.Console);
            }
            
        }

        private List<String> getProcesses()
        {
            processes = new List<String>();
            processes.Clear();

            Process[] allProcs = Process.GetProcesses();
            foreach (Process proc in allProcs)
            {
                try
                {
                    if (!string.IsNullOrEmpty(proc.MainWindowTitle)) {
                        processes.Add(Path.GetFileName(proc.MainModule.FileName));
                    }
                }
                catch (Exception) {
                    // in case of access denied
                    try
                    {
                        processes.Add(proc.ProcessName);
                    }
                    catch (Exception)
                    {}
                }
            }

            return processes;
        }

        private void populateProcesses()
        {
            getProcesses();
            foreach (String p in processes)
            {
                listProcesses.Items.Add(p);
            }
        }

        private void populateAudioDefault()
        {
            foreach (audioDevice audio in audioDevicesList)
            {
                comboDefaultAudio.Items.Add(audio.dName);
            }
        }

        private void populateAudioSettings()
        {
            comboSettingAudioDevice.Items.Clear();
            foreach (audioDevice audio in audioDevicesList)
            {
                comboSettingAudioDevice.Items.Add(audio.dName);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


            foreach (audioDevice audio in audioDevicesList)
            {
                comboDefaultAudio.Items.Add(audio.dName);
                comboSettingAudioDevice.Items.Add(audio.dName);
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;


            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = getActiveProcess();
            String audioConfig = "";
            bool changeNeeded = false;

            if (listSettings.FindString(getActiveProcess()) > -1)
            {
                // get process audio id output
                if(lastProcess.Equals(getActiveProcess()) == false)
                {
                    changeNeeded = true;

                    var inifile = new IniFile("settings\\" + getActiveProcess() + ".ini");
                    audioConfig = inifile.Read("AudioDevice", "AUDIOSETTING");
                }

            } else
            {
                // get default audio output
                changeNeeded = true;
                audioConfig = comboDefaultAudio.Text;
            }

            if (changeNeeded)
            {
                lastProcess = getActiveProcess();
                foreach (audioDevice audio in audioDevicesList)
                {
                    if (audio.dName.Equals(audioConfig))
                    {
                        setDefaultAudioOutput(audio.dId);
                        break;
                    }
                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            lbl_saved.Visible = false;
            panel1.Visible = true;
            populateAudioSettings();
            populateProcesses();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var inifile = new IniFile(@".\settings\" + listProcesses.SelectedItem + ".ini" );
            inifile.Write("Process", listProcesses.SelectedItem.ToString(), "AUDIOSETTING");
            inifile.Write("AudioDevice", comboSettingAudioDevice.SelectedItem.ToString(), "AUDIOSETTING");
            panel1.Visible = false;
            lbl_saved.Visible = true;
            loadSavedSettings();
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if (listSettings.SelectedIndex > -1)
            {
                lbl_saved.Visible = false;
                panel1.Visible = true;
                getProcesses();
                loadSetting(listSettings.SelectedItem.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(File.Exists("settings\\" + listSettings.SelectedItem + ".ini"))
            {
                File.Delete("settings\\" + listSettings.SelectedItem + ".ini");
                loadSavedSettings();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var inifile = new IniFile(@"config.ini");
            inifile.Write("StartOnBoot", chk_startonboot.Checked.ToString(), "CONFIG");
            SetStartup(chk_startonboot.Checked);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboDefaultAudio.SelectedIndex > -1)
            {
                var inifile = new IniFile(@"config.ini");
                inifile.Write("DefaultAudio", comboDefaultAudio.SelectedItem.ToString(), "CONFIG");
            }

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            loadSavedMainSettings();
        }
    }
}