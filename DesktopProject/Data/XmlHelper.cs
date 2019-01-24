using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesktopProject.Data
{
    public static class XmlHelper
    {
        public static void SaveDataToFile<T>(string fileName, ObservableCollection<T> data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<T>), new XmlRootAttribute("datalist"));
            using(TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static ObservableCollection<T> LoadDataFromFile<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<T>), new XmlRootAttribute("datalist"));
            ObservableCollection<T> records;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                records = (ObservableCollection<T>)serializer.Deserialize(fs);
            }

            return records;
        }
    }
}
