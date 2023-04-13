using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;
using APIClientApp.PostcodeIOService.HTTPManager;
using APIClientApp.PostcodeIOService.DataHandling;

namespace APIClientApp.PostcodeIOService
{
    public class SinglePostcodeService : SharedService
    {
        #region Properties

        public string SinglePostcodeResponse { get; set; }

        public DTO<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }

        #endregion

        public SinglePostcodeService()
        {
            CallManager = new CallManager();
            SinglePostcodeDTO = new DTO<SinglePostcodeResponse>();
        }

        /// <summary>
        /// This  method defines and makes the API request and stores the response
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public async Task MakeRequestAsync(string postcode)
        {
            SinglePostcodeResponse = await CallManager.MakeRequestAsync(postcode);
            JsonResponse = JObject.Parse(SinglePostcodeResponse);
            SinglePostcodeDTO.DeserializeResponse(SinglePostcodeResponse);
        }
    }
}
