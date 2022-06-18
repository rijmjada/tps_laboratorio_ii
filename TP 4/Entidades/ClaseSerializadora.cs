using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class XML<T>
    {
        public static void SerializarXML(T obj, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(sw, obj);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static T DeserializarXML(string path)
        {
            T datos = default;
            try
            {
                using (StreamReader sw = new StreamReader(path))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    datos = (T)xmlSerializer.Deserialize(sw);
                    return datos;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
