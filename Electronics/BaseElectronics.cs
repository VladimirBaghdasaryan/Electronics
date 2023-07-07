namespace Electronics
{
    abstract class BaseElectronics
    {
        public abstract string Manufacturer { get; set; }
        public abstract string Model { get; set; }
        public abstract string Color { get; set; }
        public abstract decimal Price { get; set; }
        public abstract string Guarantee { get; set; }

    }
}
