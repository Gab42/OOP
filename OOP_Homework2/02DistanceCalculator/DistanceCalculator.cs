namespace _02DistanceCalculator
{
    using System;
    using _01Point3D;

    class DistanceCalculator
    {
        public static double CalculateDistance(Point3D pointA, Point3D pointB)
        {
            return Math.Sqrt(
                Math.Pow(pointB.AxisX - pointA.AxisX, 2) +
                Math.Pow(pointB.AxisY - pointA.AxisY, 2) +
                Math.Pow(pointB.AxisZ - pointA.AxisZ, 2));
        }
    }
}
