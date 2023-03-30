using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialisationApp
{
    public class SerialiserXML : ISerialise
    {
        public MyType DeserialiseFromFile<MyType>(string filePath)
        {
            //create a new stream
            Stream fileStream = File.OpenRead(filePath);

            //Create XML Serialiser object (from System.Xml.Serialization Namespace)
            var reader = new XmlSerializer(typeof(MyType));
            var deserialisedItem = (MyType)reader.Deserialize(fileStream);
            fileStream.Close();
            return deserialisedItem;
        }

        public void SerialiseToFile<MyType>(string filePath, MyType item)
        {
            //Sets up a File Stream for us to write to. This is where we will put items
            FileStream fileStream = File.Create(filePath);

            //Create XML Serialiser object (from System.Xml.Serialization Namespace)
            var writer = new XmlSerializer(item.GetType());

            //Uses serialiser to serialise the item file
            writer.Serialize(fileStream, item);

            //Closes the file stream - i.e. open path needs to be closed
            fileStream.Close();
        }
    }
}
