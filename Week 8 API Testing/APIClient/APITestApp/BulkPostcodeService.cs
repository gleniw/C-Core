using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    public class BulkPostcodeService
    {
        #region Properties
        public RestClient Client { get; set; }

        public RestResponse Response { get; set; }

        public JObject ResponseContent { get; set; }

        public BulkPostcodeResponse ResponseObject { get; set; }

        #endregion

        public BulkPostcodeService()
        {
            Client = new RestClient(AppConfigReader.BaseUrl);
        }


        public async Task MakeBulkRequestAsync(string [] postcodes)
        {

            var bulkPostcodeRequest = new RestRequest("/postcodes/", Method.Post);
            bulkPostcodeRequest.AddHeader("Content-Type", "application/json");

            var codes = new
            {
                postcodes = postcodes
            };

            bulkPostcodeRequest.AddJsonBody(codes);

            Response = await Client.ExecuteAsync(bulkPostcodeRequest);
            ResponseContent = JObject.Parse(Response.Content);
            ResponseObject = JsonConvert.DeserializeObject<BulkPostcodeResponse>(Response.Content);
        }

    }
}

