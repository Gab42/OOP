using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private Dictionary<string, string> Attributes { get; set; }
        private string content;

        public ElementBuilder(string name)
        {           
            this.Name = name;
            this.Attributes = new Dictionary<string, string>();
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
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

        public void AddAttribute(string attribute, string value)
        {
            if (string.IsNullOrEmpty(attribute.Trim()))
            {
                throw new ArgumentException("Atribute can't be null or empty.");
            }

            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Value can't be null or empty.");
            }

            this.Attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.Content = content;
        }

        public static string operator *(ElementBuilder element, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count must be a positive number.");
            }
            StringBuilder multipleElems = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                multipleElems.Append(element);
            }

            return multipleElems.ToString();
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append($@"<{this.Name}");
            foreach (var atribute in this.Attributes)
            {
                toString.Append($@" {atribute.Key}=""{atribute.Value}""");
            }
            toString.Append(@">");
            if (this.Content != null)
            {
                toString.Append($"{this.Content}");
            }
            toString.Append($@"</{this.Name}>");
            return toString.ToString();
        }
    }
}
