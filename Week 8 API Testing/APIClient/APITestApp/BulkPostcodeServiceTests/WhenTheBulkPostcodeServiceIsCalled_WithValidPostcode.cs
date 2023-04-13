using APIClientApp.PostcodeIOService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.BulkPostcodeServiceTests
{
    public class WhenTheBulkPostcodeServiceIsCalled_WithValidPostcode
    {
        private BulkPostcodeService _bulkPostcodeService;


        [OneTimeSetUp]

        public async Task OneTimeSetupAsync() 
        {
            _bulkPostcodeService = new BulkPostcodeService();
            await _bulkPostcodeService.MakeRequestAsync(new string[] { "W3 7BF", "PO32 6DA", "NW10 6AS" });
        }

        [Test]
        public void StatusIs200_InJsonResponseBody()
        {
            Assert.That(_bulkPostcodeService.JsonResponse["status"].ToString(), Is.EqualTo("200"));
        }

        public void StatusIs200_InResponseHeader()
        {
            Assert.That((int)_bulkPostcodeService.GetStatusCode(), Is.EqualTo(200));
        }


        [Test]

        public void ContentType_IsJson()
        {
            Assert.That(_bulkPostcodeService.GetResponseContentType(), Is.EqualTo("application/json"));
        }

        [Test]

        public void ConnectionIsKeepAlive()
        {
            var result = _bulkPostcodeService.GetHeaderValue("Connection");
            Assert.That(result, Is.EqualTo("keep-alive"));
        }

        [Test]

        public void ObjectStatus_Is200()
        {
            Assert.That(_bulkPostcodeService.GetStatusCode(), Is.EqualTo(200));
        }

        //[Test]

        //public void StatusInResponseHeader()
        //{
        //    Assert.That((int)_bulkPostcodeService.Response.StatusCode, Is.EqualTo(_bulkPostcodeService.ResponseObject.status));
        //}

        //[Test]
        //public void NumberOfCodes_IsCorrect()
        //{
        //    Assert.That(_bulkPostcodeService.CodeCount(), Is.EqualTo(13));
        //}

    }
}
