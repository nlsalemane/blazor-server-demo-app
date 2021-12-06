namespace blazor_app.Data
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType Type { get; set; }
    }

    public enum DeviceType
    {
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
}