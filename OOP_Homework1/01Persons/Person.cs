using System;
using System.Linq;

namespace _01Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 100 && value >= 1)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age has to be between 1 and 100!");
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email!");
                }
            }
        }

        public override string ToString()
        {
            return "Name:" + Name + " Age:" + Age + " Email:" + Email;
        }
    }
}
