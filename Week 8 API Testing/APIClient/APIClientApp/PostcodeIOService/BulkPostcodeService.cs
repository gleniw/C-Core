using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIClientApp.PostcodeIOService.DataHandling;
using APIClientApp.PostcodeIOService.HTTPManager;

namespace APIClientApp.PostcodeIOService
{
    public class BulkPostcodeService : SharedService
    {
        #region Properties

        public string BulkPostcodeResponse { get; set; }

        public DTO<BulkPostcodeResponse> BulkPostcodeDTO { get; set; }


        #endregion
        public BulkPostcodeService()
        {
            CallManager = new CallManager();
            BulkPostcodeDTO = new DTO<BulkPostcodeResponse>();
        }

        public async Task MakeRequestAsync(string [] postcodes)
        {
            BulkPostcodeResponse = await CallManager.MakeRequestAsync(postcodes);
            
            BulkPostcodeDTO.DeserializeResponse(BulkPostcodeResponse);

        }

    }
}

