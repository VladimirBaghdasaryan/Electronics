namespace Electronics
{
    internal interface IHeadphones
    {
        public string Sensitivity { get; set; }
        public string Frequency { get; set; }
        public string AudioInput { get; set; }
        public string Microphone { get; set; }
        public string CableLength { get; set; }
    }
}
