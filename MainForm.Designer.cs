namespace WindowsAudioSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDefaultAudio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.comboSettingAudioDevice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listProcesses = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_saved = new System.Windows.Forms.Label();
            this.listSettings = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Settings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Default Audio Device:";
            // 
            // comboDefaultAudio
            // 
            this.comboDefaultAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDefaultAudio.FormattingEnabled = true;
            this.comboDefaultAudio.Location = new System.Drawing.Point(25, 49);
            this.comboDefaultAudio.Name = "comboDefaultAudio";
            this.comboDefaultAudio.Size = new System.Drawing.Size(166, 21);
            this.comboDefaultAudio.TabIndex = 7;
            this.comboDefaultAudio.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSaveSetting);
            this.panel1.Controls.Add(this.comboSettingAudioDevice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listProcesses);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(208, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 207);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(425, 164);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(114, 40);
            this.btnSaveSetting.TabIndex = 19;
            this.btnSaveSetting.Text = "Save";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboSettingAudioDevice
            // 
            this.comboSettingAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSettingAudioDevice.FormattingEnabled = true;
            this.comboSettingAudioDevice.Location = new System.Drawing.Point(268, 137);
            this.comboSettingAudioDevice.Name = "comboSettingAudioDevice";
            this.comboSettingAudioDevice.Size = new System.Drawing.Size(271, 21);
            this.comboSettingAudioDevice.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "...this process must run on device:";
            // 
            // listProcesses
            // 
            this.listProcesses.FormattingEnabled = true;
            this.listProcesses.Location = new System.Drawing.Point(18, 23);
            this.listProcesses.Name = "listProcesses";
            this.listProcesses.Size = new System.Drawing.Size(521, 108);
            this.listProcesses.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select a process to bind a audio output:";
            // 
            // lbl_saved
            // 
            this.lbl_saved.AutoSize = true;
            this.lbl_saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saved.Location = new System.Drawing.Point(270, 121);
            this.lbl_saved.Name = "lbl_saved";
            this.lbl_saved.Size = new System.Drawing.Size(439, 24);
            this.lbl_saved.TabIndex = 9;
            this.lbl_saved.Text = "Select an item on the left or create a new one.";
            // 
            // listSettings
            // 
            this.listSettings.FormattingEnabled = true;
            this.listSettings.Location = new System.Drawing.Point(25, 77);
            this.listSettings.Name = "listSettings";
            this.listSettings.Size = new System.Drawing.Size(166, 147);
            this.listSettings.TabIndex = 10;
            this.listSettings.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(161, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus.png");
            this.imageList1.Images.SetKeyName(1, "plus.png");
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(125, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Start on Boot";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current process:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Current process:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 264);
            this.Controls.Add(this.lbl_saved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboDefaultAudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Audio Switcher - by Process";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDefaultAudio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_saved;
        private System.Windows.Forms.ListBox listSettings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listProcesses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.ComboBox comboSettingAudioDevice;
        private System.Windows.Forms.Label label7;
    }
}

