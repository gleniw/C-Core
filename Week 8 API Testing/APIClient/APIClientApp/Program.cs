using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static System.Formats.Asn1.AsnWriter;
using System.Linq;

namespace APIClientApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Creating Client is the 1st step

            //Encapsulates info we need to make the API call
            //Allows us to send authenticated HTTPS requests

            var restClient = new RestClient("https://api.postcodes.io/"); //Set base Url

            //Set up request to API
            var restRequest = new RestRequest();

            //Optional as default is always Get
            restRequest.Method = Method.Get;

            //Extra information/instruction to be sent - Formatting
            restRequest.AddHeader("Content-Type", "application/json"); //want to be returned as a JSON file

            //Add the resource
            string postcode = "EC2Y 5AS"; //Resource to query i.e. endpoint

            restRequest.Resource = $"postcodes/{postcode.ToLower()}";

            //Execute Responce - stored in singlePostcodeResponce variable
            RestResponse singlePostcodeResponse = restClient.Execute(restRequest);

            //Returns body as an unformatted string
            Console.WriteLine("Responce content (string)");
            Console.WriteLine(singlePostcodeResponse.Content);

            Console.WriteLine("Responce Status (int)");
            Console.WriteLine(singlePostcodeResponse.StatusCode); //Emun repsponce
            Console.WriteLine((int)singlePostcodeResponse.StatusCode); //Cast to int for 200 status code


            Console.WriteLine("Printing Headers");
            foreach (var header in singlePostcodeResponse.Headers)
            {
                Console.WriteLine(header);
            }

            Console.WriteLine("\nFiltering with Key");
            //Headers where the key is the date and if there are several values, return the first or default (zero/null)
            var headers = singlePostcodeResponse.Headers;
            var responseDateHeader = headers.Where(h => h.Name == "Date")
                .Select(h => h.Value).FirstOrDefault(); //First or Default will return first that matches
            Console.WriteLine(responseDateHeader);


            Console.WriteLine("Copied from Postman - API Request in C# Code");

            var options = new RestClientOptions("https://api.postcodes.io")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var bulkPostcodeRequest = new RestRequest("/postcodes/", Method.Post);
            bulkPostcodeRequest.AddHeader("Content-Type", "application/json");

            //var body = @"{" + "\n" + @" ""postcodes"" : [""OX49 5NU"", ""M32 0JG"", ""NE30 1DP""]" + "\n" + @"}"; //From Postman
            var postcodes = new
            {
                Postcodes = new string[] { "OX49 5NU", "M32 0JG", "NE30 1DP" } //Postcodes is an anon type with a bunch of String arrays - Read Only
            };
            //Nish code to replace Postman

            //request.AddStringBody(body, DataFormat.Json); //Treat String like a JSON String //From Postman
            //request.AddJsonBody(postcodes);
            bulkPostcodeRequest.AddJsonBody(postcodes);

            RestResponse bulkPostcodeResponse = await client.ExecuteAsync(bulkPostcodeRequest); //Quick Actions - Make method Async
            Console.WriteLine(bulkPostcodeResponse.Content);

            //Serialise to Json String - taking Postcodes anon object and converting to Json String

            #region
            //NewtonSoft to Serilaise and Query

            Console.WriteLine("Formatted JObject");
            var singlePostJsonResponse = JObject.Parse(singlePostcodeResponse.Content);
            Console.WriteLine("\n Response content as a Jobject");
            Console.WriteLine(singlePostJsonResponse);

            Console.WriteLine("Return Status");
            Console.WriteLine(singlePostJsonResponse["status"]); //Query JObject - Specify required Key

            Console.WriteLine("Return Admin District");
            Console.WriteLine(singlePostJsonResponse["result"]["admin_district"]);

            Console.WriteLine("Json Array of Objects");
            //Returning Specific item from Json object list
            var bulkPostcodeJsonResponse = JObject.Parse(bulkPostcodeResponse.Content);
            var adminDistrict = bulkPostcodeJsonResponse["result"][1]["result"]["admin_district"];
            Console.WriteLine($"\nAdmin District of 2nd Post code {adminDistrict}");

            Console.WriteLine("\nUsing Classes");

            var singlePostcodeObjectResponse = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content);
            Console.WriteLine(singlePostcodeObjectResponse.status);
            Console.WriteLine(singlePostcodeObjectResponse.result.region);


            Console.WriteLine("\nBulk Serialisation");

            var bulkPostcodeObject = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkPostcodeResponse.Content);
            Console.WriteLine(bulkPostcodeObject.status);
            Console.WriteLine(bulkPostcodeObject.result[0].result.region);
            #endregion


            ////// Task

            ////Part 2:
            ////Read the documentation for the postcodes.io Lookup Outward Code GET request.Try it out in Postman
            ////Modify your program to create a Lookup Outward Code request, and store the response as

            //Console.WriteLine("\n Outward Look up");



            //Console.WriteLine("\nStatus");
            //var singleOutCodeObjectResponse = JsonConvert.DeserializeObject<OutCodeResponce>(OutResponse.Content);
            //Console.WriteLine(singleOutCodeObjectResponse.status);


            ////a Newtonsoft JObject
            ////one or more deserialised C# objects.
            ////You will need to map several new classes to represent the response.

            //Console.WriteLine("\nFormatted JObject");
            //var singleOutCodeJsonResponse = JObject.Parse(OutResponse.Content);
            //Console.WriteLine("\n Response content as a Jobject");
            //Console.WriteLine(singleOutCodeJsonResponse);

            ////Different class for each model single / multiple

        }
    }
}