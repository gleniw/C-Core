using System;
using TechTalk.SpecFlow;
using APIClientApp;
using APIClientApp.PostcodeIOService;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiTestApp.Specflow
{
    [Binding]
    [Scope(Feature = "SinglePostcodeRequest")] //Separate step definition for each feature file
    public class SinglePostcodeRequestStepDefinitions
    {
        private static string _testDataLocation = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Test Data\"); //This keeps it relative if other needs to use i.e. Github collab
        private static SinglePostcodeService _spcs;

        [BeforeFeature] //Must be static as only one instance is run for that class

        [Given(@"I have initialized the SinglePostcodeService")]
        public static void GivenIHaveInitializedTheSinglePostcodeService()
        {
            _spcs = new SinglePostcodeService();
        }


        [When(@"I make a request for the postcode ""([^""]*)""")]
        public async Task WhenIMakeARequestForThePostcode(string postcode)
        {
            await _spcs.MakeRequestAsync(postcode);
        }


        [Then(@"Status in the JSON response body should be (.*)")]
        public void ThenStatusInTheJSONResponseBodyShouldBe(string status)
        {
            Assert.That(_spcs.JsonResponse["status"].ToString(), Is.EqualTo(status));
        }


        [Then(@"the status header should be (.*)")]
        public void ThenTheStatusHeaderShouldBe(int status)
        {
            Assert.That(_spcs.GetStatusCode, Is.EqualTo(status));
        }

        [Then(@"The JSON Response body should match the JSON Schema in ""([^""]*)""")]
        public void ThenTheJSONResponseBodyShouldMatchTheJSONSchemaIn(string location)
        {
            var expectedJsonString = File.ReadAllText(_testDataLocation + location);
            var expectedJsonObject = JObject.Parse(expectedJsonString);
            Assert.That(_spcs.JsonResponse, Is.EqualTo(expectedJsonObject));
        }


    }
}
