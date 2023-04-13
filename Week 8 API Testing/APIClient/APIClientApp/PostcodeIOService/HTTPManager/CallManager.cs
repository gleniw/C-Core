using APIClientApp.PostcodeIOService.DataHandling;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodeIOService.HTTPManager
{
    public class CallManager
    {

        private readonly RestClient _client;
        public RestResponse RestResponse { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakeRequestAsync(string postcode)
        {
            var singlePostcodeRequest = new RestRequest();
            singlePostcodeRequest.AddHeader("Content-Type", "application/json");
            singlePostcodeRequest.Resource = $"postcodes/{postcode}";

            RestResponse = await _client.ExecuteAsync(singlePostcodeRequest);
            return RestResponse.Content;
        }

        public async Task<string> MakeRequestAsync(string [] postcodes)
        {

            var bulkPostcodeRequest = new RestRequest("/postcodes/", Method.Post);
            bulkPostcodeRequest.AddHeader("Content-Type", "application/json");

            var codes = new
            {
                postcodes
            };

            bulkPostcodeRequest.AddJsonBody(codes);
            RestResponse = await _client.ExecuteAsync(bulkPostcodeRequest);
            return RestResponse.Content;
        }

    }
}
