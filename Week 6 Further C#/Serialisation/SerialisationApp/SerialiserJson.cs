using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerialisationApp
{
    public class SerialiserJson : ISerialise
    {
        public MyType DeserialiseFromFile<MyType>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            //Newtonsoft .json to deserialised Json file
            return JsonConvert.DeserializeObject<MyType>(jsonString);
            
        }

        public void SerialiseToFile<MyType>(string filePath, MyType item)
        {
            string jsonString = JsonConvert.SerializeObject(item);
            File.WriteAllText(filePath, jsonString); //Does the filestream 
            
        }
    }
}
