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

        public async Task OneTimeSetupAsync() //This method needs to be Async if called another Async method
        {
            _bulkPostcodeService = new BulkPostcodeService();
            await _bulkPostcodeService.MakeBulkRequestAsync(new string [] {"W3 7BF", "PO32 6DA", "NW10 6AS"});
            //await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS").GetAwaiter().GetResult; //Alternative to changing to Async method
        }

        [Test]
        public void StatusIs200_InJsonResponseBody()
        {
            Assert.That(_bulkPostcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        public void StatusIs200_InResponseHeader()
        {
            Assert.That((int)_bulkPostcodeService.Response.StatusCode, Is.EqualTo(200));
        }


        [Test]

        public void ContentType_IsJson()
        {
            Assert.That(_bulkPostcodeService.Response.ContentType, Is.EqualTo("application/json"));
        }

        [Test]

        public void ConnectionIsKeepAlive()
        {
            var result = _bulkPostcodeService.Response.Headers.Where(x => x.Name == "Connection")
            .Select(x => x.Value).FirstOrDefault();
            Assert.That(result, Is.EqualTo("keep-alive"));
        }

        [Test]

        public void ObjectStatus_Is200()
        {
            Assert.That(_bulkPostcodeService.ResponseObject.status, Is.EqualTo(200));
        }

        [Test]

        public void StatusInResponseHeader()
        {
            Assert.That((int)_bulkPostcodeService.Response.StatusCode, Is.EqualTo(_bulkPostcodeService.ResponseObject.status));
        }

    }
}
