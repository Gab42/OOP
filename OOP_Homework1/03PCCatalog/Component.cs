using System;

namespace _03PCCatalog
{
    public class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(decimal price, string name, string details)
        {
            this.Price = price;
            this.Name = name;
            this.Details = details;
        }

        public Component(decimal price, string name) : this(price, name, null)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
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
            get { return this.price; }
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

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != "")
                {
                    details = value;
                }
                else
                {
                    throw new ArgumentException("Details cannot be an empty string!");
                }
            }
        }
    }
}
