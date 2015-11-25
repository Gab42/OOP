using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HTMLDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var div = new ElementBuilder("div");
                div.AddAttribute("id", "page");
                div.AddAttribute("class", "big");
                div.AddContent("<p>Hello</p>");
                Console.WriteLine(div * 3);

                Console.WriteLine(HTMLDispatcher.CreateImage("http://vicove.com/jokepics/thumb_sredna_51453.jpg", "bus", "bus.rar"));
                Console.WriteLine(HTMLDispatcher.CreateUrl("http://vicove.com/", "Click me for more fun", "vicove.com"));
                Console.WriteLine(HTMLDispatcher.CreateInput("textform", "email", "something@something.com"));
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
