namespace WindowsAudioSwitcher
{
    public class audioDevice
    {
        public string dName { get; set; }
        public  string dId { get; set; }

        public audioDevice(string device_name, string device_id)
        {
            dName = device_name;
            dId = device_id;
        }

    }
}