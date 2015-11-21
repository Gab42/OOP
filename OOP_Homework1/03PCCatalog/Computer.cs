using System;
using System.Collections.Generic;

namespace _03PCCatalog
{
    public class Computer
    {
        private string name;
        private decimal price = 0;
        private List<Component> components = new List<Component>();

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be an empty string!");
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
                    throw new ArgumentException("Price cannot be a negative number!");
                }
            }
        }

        public Computer(string name, params Component[] component)
        {
            this.Name = name;
            foreach (var item in component)
            {
                this.components.Add(item);
                this.Price += item.Price;
            }
        }

        public Computer(string name)
        {
            this.Name = name;
        }
        public Computer(params Component[] component) : this("[Unnamed]", component)
        {
        }

        public Computer() : this("[Unnamed]")
        {
        }

        public void Print()
        {
            Console.WriteLine("Computername: {0}", this.Name);
            foreach (var item in this.components)
            {
                Console.WriteLine("Component name: {0}, price: {1:F2} lv.", item.Name, item.Price);
            }
            Console.WriteLine("Total computer price: {0:F2} lv.", this.Price);
            Console.WriteLine("#################################################");
        }
    }
}
