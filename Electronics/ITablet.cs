namespace Electronics
{
    internal interface ITablet
    {
        public string WorkspaceSize { get; set; }
        public string Format { get; set; }
        public string PressureSensitivity { get; set; }
        public string ResponseSpeed { get; set; }
        public  string MemoryCapacity { get; set; }

    }
}
