
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace SerialisationApp
{
    public class SerialiserYAML : ISerialise
    {
        public MyType DeserialiseFromFile<MyType>(string filePath)
        {
            var deserialiser = new DeserializerBuilder().Build();
            string yamlString = File.ReadAllText(filePath);
            return deserialiser.Deserialize<MyType>(new StringReader(yamlString));
        }

        public void SerialiseToFile<MyType>(string filePath, MyType item)
        {
            var serialiser = new SerializerBuilder().Build();
            string yamlString = serialiser.Serialize(item);
            File.WriteAllText(filePath, yamlString);
        }
    }
}
