using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.OutcodeServiceTests
{
    public class WhenTheOutcodeServiceIsCalled_WithValidOutcode
    {
        //    private OutcodeService _OutcodeService;

        //    [OneTimeSetUp]

        //    public async Task OneTimeSetupAsync()
        //    {
        //        _OutcodeService = new OutcodeService();
        //        await _OutcodeService.MakeOutcodeRequestAsync("W3");

        //    }

        //    [Test]
        //    public void StatusIs200_InJsonResponseBody()
        //    {
        //        Assert.That(_OutcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        //    }

        //    [Test]

        //    public void StatusIs200_InResponseHeader()
        //    {
        //        Assert.That((int)_OutcodeService.Response.StatusCode, Is.EqualTo(200));
        //    }

        //    [Test]
        //    public void CorrectOutcodeIsReturned()
        //    {
        //        var result = _OutcodeService.ResponseContent["result"]["outcode"].ToString();
        //        Assert.That(result, Is.EqualTo("W3"));
        //    }

        //    [Test]

        //    public void ContentType_IsJson()
        //    {
        //        Assert.That(_OutcodeService.Response.ContentType, Is.EqualTo("application/json"));
        //    }

        //    [Test]

        //    public void ConnectionIsKeepAlive()
        //    {
        //        var result = _OutcodeService.Response.Headers.Where(x => x.Name == "Connection")
        //        .Select(x => x.Value).FirstOrDefault();
        //        Assert.That(result, Is.EqualTo("keep-alive"));
        //    }

        //    [Test]

        //    public void ObjectStatus_Is200()
        //    {
        //        Assert.That(_OutcodeService.ResponseObject.status, Is.EqualTo(200));
        //    }

        //    [Test]

        //    public void StatusInResponseHeader()
        //    {
        //        Assert.That((int)_OutcodeService.Response.StatusCode, Is.EqualTo(_OutcodeService.ResponseObject.status));
        //    }

        //    //[Test]

        //    //public void AdminDistrict_IsCityOfLondon()
        //    //{
        //    //    Assert.That(_OutcodeService.ResponseObject.result.country, Is.EqualTo("England"));
        //    //}
    }
}
