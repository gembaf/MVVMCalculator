﻿using System.IO;
using System.Xml.Serialization;

namespace MVVMCalculator.Model.XML
{
    public static class XMLFileManager
    {
        #region public static method

        public static T ReadXml<T>(string filePath) where T : new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader stream;
            T obj;
            try
            {
                stream = new StreamReader(filePath);
                obj = (T)serializer.Deserialize(stream);
                stream.Close();
            }
            catch (System.Exception)
            {
                obj = new T();
            }
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
