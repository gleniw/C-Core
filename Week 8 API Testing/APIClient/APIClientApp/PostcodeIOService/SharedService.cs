using APIClientApp.PostcodeIOService.DataHandling;
using APIClientApp.PostcodeIOService.HTTPManager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodeIOService
{
    public class SharedService
    {
        #region Properties


        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }


        #endregion

        public int GetStatusCode()
        {
            return (int)CallManager.RestResponse.StatusCode;
        }

        public string GetHeaderValue(string name)
        {
            return CallManager.RestResponse.Headers.Where(x => x.Name == name).Select(x => x.Value.ToString()).FirstOrDefault();
        }

        public string GetResponseContentType()
        {
            return CallManager.RestResponse.ContentType;
        }

        public int CodeCount()
        {
            var count = 0;
            foreach (var code in JsonResponse["result"]["codes"])
            {
                count++;
            }
            return count;
        }
    }
}
