using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
    public class Laptop : Battery
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string cpu;
        private int ram;
        private string graphics;
        private int disk;
        private string screen;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    model = value;
                }
                else
                {
                    throw new System.ArgumentException("Model name cannot be empty!");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != "")
                {
                    manufacturer = value;
                }
                else
                {
                    throw new System.ArgumentException("Manufacturer name cannot be an empty string!");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new System.ArgumentException("Price cannot be a negative number!");
                }
            }
        }

        public string Cpu
        {
            get
            {
                return this.cpu;
            }
            set
            {
                if (value != "")
                {
                    cpu = value;
                }
                else
                {
                    throw new System.ArgumentException("CPU cannot be an empty string!");
                }
            }
        }

        public string Graphics
        {
            get
            {
                return this.graphics;
            }
            set
            {
                if (value != "")
                {
                    graphics = value;
                }
                else
                {
                    throw new System.ArgumentException("Graphics card cannot be an empty string!");
                }
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != "")
                {
                    screen = value;
                }
                else
                {
                    throw new System.ArgumentException("Screen cannot be an empty string!");
                }
            }
        }

        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value >= 0)
                {
                    ram = value;
                }
                else
                {
                    throw new System.ArgumentException("RAM cannot be a negative number!");
                }
            }
        }

        public int Disk
        {
            get
            {
                return this.disk;
            }
            set
            {
                if (value >= 0)
                {
                    disk = value;
                }
                else
                {
                    throw new System.ArgumentException("Disk size cannot be a negative number!");
                }
            }
        }

        public Laptop(string Model, decimal Price) : this(Model, Price, null, null, 0, null, 0, null)
        {
        }

        public Laptop(string Model, decimal Price, string Cpu, int Ram) : this(Model, Price, null, Cpu, Ram, null, 0, null)
        {
        }

        public Laptop(string Model, decimal Price, string Manufacturer, string Cpu, int Ram, string Graphics, int Disk, string Screen)
            : this(Model, Price, Manufacturer, Cpu, Ram, Graphics, Disk, Screen, null, 0)
        {
        }

        public Laptop(string Model, decimal Price, string Manufacturer, string Cpu, int Ram, string Graphics, int Disk, string Screen, string BatteryName, double BatteryLife)
            : base(BatteryName, BatteryLife)
        {
            this.Model = Model;
            this.Price = Price;
            this.Cpu = Cpu;
            this.Ram = Ram;
            this.Graphics = Graphics;
            this.Disk = Disk;
            this.Screen = Screen;
        }

        public override string ToString()
        {
            return "Model:" + this.Model + " Price:" + this.Price + " CPU:" + this.Cpu + " RAM:" + this.Ram + " Graphics card:" + this.Graphics +
                " Disk:" + this.Disk + " Screen:" + this.Screen + " Battery:" + this.BatteryName + " Battery life:" + this.BatteryLife;
        }
    }
}
