namespace Electronics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iPhone iPhone10 = new iPhone("Apple", "iPhone 10", "Black", 200.000m, "1 Year", "128 Gb",
                "48+12+12 Mpiks", "IOS", "6.1");
            iPhone10.PrintInfo();

            SamsungPhone galaxyM33 = new SamsungPhone("Samsung", "Galaxy M33", "Blue", 140.000m, "1 Year", "64 Gb",
               "50 + 5 + 2 + 2", "Android", "5");
            galaxyM33.PrintInfo();

            XiaomiTablet miLCDWritingTablet = new XiaomiTablet("Xiaomi", "Mi LCD Writing Tablet 13.5\" BHR4245GL", "White", 180.000m, "1 Year", "32 Gb",
                 "280 х 210 mm", "A4", "2048 levels", "266 pps");
            miLCDWritingTablet.PrintInfo();

            CanyonHeadphone cns_CEP3DG = new CanyonHeadphone("Canyon", "CNS-CEP3DG", "Black", 5.000m, "1 Year", "100 db", "20 - 20000 gh",
                "mini jack 3.5 mm","Built-in", "1,2 m");
            cns_CEP3DG.PrintInfo();

        }
    }
}