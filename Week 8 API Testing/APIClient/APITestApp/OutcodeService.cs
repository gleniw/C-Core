using APIClientApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    public class OutcodeService
    {
        #region Properties

        public RestClient Client { get; set; }

        public RestResponse Response { get; set; }

        public JObject ResponseContent { get; set; }

        public OutcodeResponse ResponseObject { get; set; }

        #endregion

        public OutcodeService()
        {
            Client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task MakeOutcodeRequestAsync(string outcode)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"outcodes/{outcode}";
            Response = await Client.ExecuteAsync(request);
            ResponseContent = JObject.Parse(Response.Content);
            ResponseObject = JsonConvert.DeserializeObject<OutcodeResponse>(Response.Content);
        }
    }
}
