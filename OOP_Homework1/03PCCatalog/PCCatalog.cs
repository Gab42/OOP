using System;
using System.Collections.Generic;

namespace _03PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            // Use "." instead of "," for numbers.
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            try
            {
                var motherboard1 = new Component(44.80m, "Cheap Motherboard");
                var motherboard2 = new Component(85.50m, "Deluxe Motherboard");
                var cpu1 = new Component(81.20m, "CPU 2 cores");
                var cpu2 = new Component(190.20m, "CPU 4 cores");
                var graphics1 = new Component(130m, "Fancy graphics");
                var psu1 = new Component(75.35m, "Powerful PSU");
                var psu2 = new Component(30.90m, "Second-hand PSU");

                var pc1 = new Computer("PC1", motherboard1, cpu2, psu1);
                var pc2 = new Computer("PC2", motherboard2, cpu1, graphics1, psu1);
                var pc3 = new Computer("PC3", motherboard1, psu2);
                var pc4 = new Computer(psu1, graphics1, cpu1);

                List<Computer> list = new List<Computer>();
                list.Add(pc1);
                list.Add(pc2);
                list.Add(pc3);
                list.Add(pc4);
                list.Sort((x, y) => x.Price.CompareTo(y.Price));

                foreach (var item in list)
                {
                    item.Print();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
