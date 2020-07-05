using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    public class DatManage
    {


        public void SerializeXML<T>(T users, string path) where T : class
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xml.Serialize(fs, users);
            }
        }
        public T DeserializeXML<T>(string SelectedPath) where T : class
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(SelectedPath, FileMode.OpenOrCreate))
            {
                return (T)xml.Deserialize(fs);
            }

        }

    }
}
