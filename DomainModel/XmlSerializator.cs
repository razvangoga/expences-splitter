using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace DomainModel
{
    public class XmlSerializator
    {
        public static string UTF8ByteArrayToString(Byte[] characters)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            string constructedString = encoding.GetString(characters);
            return (constructedString);
        }
        public static byte[] StringToUTF8ByteArray(string xmlAsString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byteArray = encoding.GetBytes(xmlAsString);
            return byteArray;
        }

        public static T Deserialize<T>(string fileName)
        {
            string xmlAsString = string.Empty;
            StreamReader streamReader = new StreamReader(fileName);
            xmlAsString = streamReader.ReadToEnd();

            streamReader.Close();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(xmlAsString));
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

            T seralizedObject = (T)xmlSerializer.Deserialize(memoryStream);
            return seralizedObject;
        }

        public static void Serialize<T>(T objectToBeSaved, string fileName)
        {
            string xmlAsString = string.Empty;
            MemoryStream memoryStream = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;

            serializer.Serialize(xmlTextWriter, objectToBeSaved);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            xmlAsString = UTF8ByteArrayToString(memoryStream.ToArray());

            StreamWriter streamWriter = new StreamWriter(fileName, false);

            streamWriter.Write(xmlAsString);
            streamWriter.Close();
        }
    }
}
