namespace Electronics
{
    internal class Headphones: BaseElectronics, IHeadphones
    {
        public override string Manufacturer { get; set; }
        public override string Model { get; set; }
        public override string Color { get; set; }
        public override decimal Price { get; set; }
        public override string Guarantee { get; set; }
        public string Sensitivity { get; set; }
        public string Frequency { get; set; }
        public string AudioInput { get; set; }
        public string Microphone { get; set; }
        public string CableLength { get; set; }

        public Headphones(string manufacturer, string model, string color, decimal price, string guarantee, 
            string sensitivity, string frequency, string audioInput, string microphone, string cableLength)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            Price = price;
            Guarantee = guarantee;
            Sensitivity = sensitivity;
            Frequency = frequency;
            AudioInput = audioInput;
            Microphone = microphone;
            CableLength = cableLength;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}\nModel: {Model}\nColor: {Color}\nPrice: {Price} Amd\nGuarantee: {Guarantee}\n" +
                $"Sensitivity: {Sensitivity}\nFrequency: {Frequency}\nAudioInput: {AudioInput}\n" +
                $"Microphone: {Microphone}\nCableLength: {CableLength}\n");
        }
    }
}
