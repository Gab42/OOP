using System;

namespace _02LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            try
            {
                var pc1 = new Laptop("Toshiba", 3422);
                Console.WriteLine(pc1.ToString());

                var pc2 = new Laptop("Lenovo", -2400, "Intel", 8);
                Console.WriteLine(pc2.ToString());
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
