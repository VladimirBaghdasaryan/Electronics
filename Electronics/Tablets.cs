namespace Electronics
{
    internal class Tablets : BaseElectronics, ITablet
    {
        public override string Manufacturer { get; set ; }
        public override string Model { get ; set; }
        public override string Color { get ; set; }
        public override decimal Price { get; set; }
        public override string Guarantee { get ; set; }
        public string WorkspaceSize { get ; set ; }
        public string Format { get; set ; }
        public string PressureSensitivity { get ; set ; }
        public string ResponseSpeed { get; set; }
        public string MemoryCapacity { get; set; }

        public Tablets(string manufacturer, string model, string color, decimal price, string guarantee, string memoryCapacity,
             string workspaceSize, string format, string pressureSensitivity, string responseSpeed)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            Price = price;
            Guarantee = guarantee;
            MemoryCapacity = memoryCapacity;
            WorkspaceSize = workspaceSize;
            Format = format;
            PressureSensitivity = pressureSensitivity;
            ResponseSpeed = responseSpeed;
        }

        public void PrintInfo()
        {
             Console.WriteLine($"Manufacturer: {Manufacturer}\nModel: {Model}\nColor: {Color}\nPrice: {Price} Amd\nGuarantee: {Guarantee}\n" +
                $"MemoryCapacity: {MemoryCapacity}\nWorkspaceSize: {WorkspaceSize}\nFormat: {Format}\n" +
                $"PressureSensitivity: {PressureSensitivity}\nResponseSpeed:{ResponseSpeed}\n");
        }
    }
}
