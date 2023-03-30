using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp
{
    public interface ISerialise
    {
        void SerialiseToFile<MyType>(string filePath, MyType item); //<> passes in the Type 
        MyType DeserialiseFromFile<MyType>(string filePath);
    }
}
