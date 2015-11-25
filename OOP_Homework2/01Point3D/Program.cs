using System;

namespace _01Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point3D(20, 8.5, 11);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
