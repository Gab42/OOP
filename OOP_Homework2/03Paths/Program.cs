using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Paths
{
    using System;
    using _01Point3D;

    public class Program
    {
        private const string File = @"../../3Dpath.xml";
        static void Main(string[] args)
        {
            var path1 = new Path3D(
               new Point3D(5, 20.7, -8),
               new Point3D(6, 65, -6),
               new Point3D(1, 5, 10),
               new Point3D(0.5, -9.9, -6.9));

            Storage.SavePath(File, path1);
            Path3D path2 = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, path2.Path));
        }
    }
}
