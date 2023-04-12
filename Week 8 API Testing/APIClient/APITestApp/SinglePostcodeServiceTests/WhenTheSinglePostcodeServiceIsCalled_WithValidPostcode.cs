﻿
namespace APITestApp.SinglePostcodeServiceTests
{
    [Category("Happy")]
    public class WhenTheSinglePostcodeServiceIsCalled_WithValidPostcode
    {
        private SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp] 

        public async Task OneTimeSetupAsync() //This method needs to be Async if called another Async method
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS");
            //await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS").GetAwaiter().GetResult; //Alternative to changing to Async method
        }

        [Test]
        public void StatusIs200_InJsonResponseBody()
        {
            Assert.That(_singlePostcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]

        public void StatusIs200_InResponseHeader()
        {
            Assert.That((int)_singlePostcodeService.Response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void CorrectPostcodeIsReturned()
        {
            var result = _singlePostcodeService.ResponseContent["result"]["postcode"].ToString();
            Assert.That(result, Is.EqualTo("EC2Y 5AS"));
        }

        [Test]

        public void ContentType_IsJson()
        {
            Assert.That(_singlePostcodeService.Response.ContentType, Is.EqualTo("application/json"));
        }

        [Test]

        public void ConnectionIsKeepAlive()
        {
            var result = _singlePostcodeService.Response.Headers.Where(x => x.Name == "Connection")
            .Select(x => x.Value).FirstOrDefault();
            Assert.That(result, Is.EqualTo("keep-alive"));
        }

        [Test]

        public void ObjectStatus_Is200()
        {
            Assert.That(_singlePostcodeService.ResponseObject.status, Is.EqualTo(200));
        }

        [Test]

        public void StatusInResponseHeader()
        {
            Assert.That((int)_singlePostcodeService.Response.StatusCode, Is.EqualTo(_singlePostcodeService.ResponseObject.status));
        }

        [Test]

        public void AdminDistrict_IsCityOfLondon()
        {
            Assert.That(_singlePostcodeService.ResponseObject.result.admin_district, Is.EqualTo("City of London"));
        }
    }
}

