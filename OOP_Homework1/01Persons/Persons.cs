using System;

namespace _01Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
           try
           {
                Person p1 = new Person("John", 99);
                Console.WriteLine(p1.ToString());
                Person p2 = new Person("Ana", 21, "ana@yahoo.com");
                p2.Age = 101;
                Console.WriteLine(p2.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
