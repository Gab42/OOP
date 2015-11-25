using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _03Paths
{
    public static class Storage
    {
        public static Path3D LoadPath(string source)
        {
            using (StreamReader reader = new StreamReader(source))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Path3D));
                return (Path3D)serializer.Deserialize(reader);
            }
        }

        public static void SavePath(string destination, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter(destination))
            {
                XmlSerializer serialized = new XmlSerializer(path.GetType());
                serialized.Serialize(writer, path);
            }
        }
    }
}
