using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodeIOService.DataHandling
{
    public class DTO<T> where T : IResponse, new()
    {
        public T Response { get; set; }
        //C# Json Object
        public void DeserializeResponse(string postcodeResponse)
        {
            Response = JsonConvert.DeserializeObject<T>(postcodeResponse);
        }
    }
}
