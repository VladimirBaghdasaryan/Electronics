namespace Electronics
{
    internal class iPhone : Phones
    {
        public iPhone(string manufacturer, string model, string color, decimal price, string guarantee, string memorycapacity, string cameraResolution, string operatingSystem, string screenResolution) :
            base(manufacturer, model, color, price, guarantee, memorycapacity, cameraResolution, operatingSystem, screenResolution)
        {
        }
    }
}
