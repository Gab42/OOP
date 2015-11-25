namespace _02DistanceCalculator
{
    using System;
    using _01Point3D;

    class Program
    {
        static void Main(string[] args)
        {
            var pointA = new Point3D(20.5, 12.8, 6);
            var pointB = new Point3D(-4, 5.5, 50);

            Console.WriteLine($"{DistanceCalculator.CalculateDistance(pointA, pointB):F8}");
        }
    }
}
