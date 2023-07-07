namespace Electronics
{
    internal class Phones : BaseElectronics, IMobile
    {
        public override string Manufacturer { get ; set ; }
        public override string Model {get; set ; }
        public override string Color {get; set ; }
        public override decimal Price { get; set; }
        public override string Guarantee { get ; set; }
        public  string MemoryCapacity { get; set; }
        public string CameraResolution { get; set ; }
        public string OperatingSystem { get; set ; }
        public string ScreenResolution { get; set ; }
        public  bool Bluetooth { get; set; }

        public Phones(string manufacturer, string model, string color, decimal price, string guarantee, 
            string memorycapacity, string cameraResolution, string operatingSystem, string screenResolution)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            Price = price;
            Guarantee = guarantee;
            MemoryCapacity = memorycapacity;
            CameraResolution = cameraResolution;
            OperatingSystem = operatingSystem;
            ScreenResolution = screenResolution;
         }
        public void PrintInfo()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}\nModel: {Model}\nColor: {Color}\nPrice: {Price} Amd\nGuarantee: {Guarantee}\n" +
                $"MemoryCapacity: {MemoryCapacity}\nCameraResolution: {CameraResolution}\nOperatingSystem: {OperatingSystem}\n" +
                $"ScreenResolution: {ScreenResolution}\n");
        }

    }
}
