namespace Electronics
{
    internal class CanyonHeadphone : Headphones
    {
        public CanyonHeadphone(string manufacturer, string model, string color, decimal price, string guarantee, string sensitivity, string frequency, string audioInput, string microphone, string cableLength) 
            : base(manufacturer, model, color, price, guarantee, sensitivity, frequency, audioInput, microphone, cableLength)
        {
        }
    }
}
