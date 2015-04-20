using System.IO;
using System.Xml.Serialization;

namespace MVVMCalculator.Model.XML
{
    public static class XMLFileManager
    {
        #region public static method

        public static T ReadXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader stream = new StreamReader(filePath);
            T obj = (T)serializer.Deserialize(stream);
            stream.Close();
            return obj;
        }

        public static void WriteXml<T>(string filePath, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter stream = new StreamWriter(filePath);
            serializer.Serialize(stream, obj);
            stream.Close();
        }

        #endregion
    }
}
