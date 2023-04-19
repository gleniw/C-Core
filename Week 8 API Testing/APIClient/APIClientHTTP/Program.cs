using APIClientApp.PostcodeIOService.DataHandling;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;

namespace APIClientHTTP
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient()) // IDisposable interface
            {
                #region Single
                var singlePostcodeRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Get //Get by default
                };

                
                var postcode = "EC2Y 5AS";
                singlePostcodeRequest.RequestUri = new Uri($"https://api.postcodes.io/postcodes/{postcode}");

                #endregion

                #region Bulk

                var bulkPostcodeRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Post //Get by default
                };
                bulkPostcodeRequest.Headers.Add("Accept", "application/json");

                //Creating Array
                var postcodes = new
                {
                    Postcodes = new string[] { "OX49 5NU", "M32 0JG", "NE30 1DP" } //Postcodes is an anon type with a bunch of String arrays - Read Only
                };

                //Sending Content
                bulkPostcodeRequest.Content = JsonContent.Create(postcodes);
                bulkPostcodeRequest.RequestUri = new Uri($"https://api.postcodes.io/postcodes/");


                #endregion

                try
                {

                    Console.WriteLine("\nResponse");
                    HttpResponseMessage singlePostcodeResponse = await client.SendAsync(singlePostcodeRequest);
                    Console.WriteLine(singlePostcodeResponse.Content.ReadAsStringAsync().Result);

                    Console.WriteLine("\nResponse");
                    HttpResponseMessage bulkPostcodeResponse = await client.SendAsync(bulkPostcodeRequest);
                    Console.WriteLine(bulkPostcodeResponse.Content.ReadAsStringAsync().Result);


                    // Take this single response and get the status code and headers e.g. Date
                    Console.WriteLine("\nSingle Response");
                    Console.WriteLine(singlePostcodeResponse.Headers.Date);
                    Console.WriteLine(singlePostcodeResponse.Headers.GetValues("date").FirstOrDefault());

                    // Serialise to a JObject (need to install Newtonsoft)
                    Console.WriteLine("\nJObject Response");
                    var singlePostJsonResponse = JObject.Parse(singlePostcodeResponse.Content.ReadAsStringAsync().Result); //Await
                    Console.WriteLine(singlePostJsonResponse);

                    // Few examples of Querying JObject
                    Console.WriteLine("\nReturn Status");
                    Console.WriteLine(singlePostJsonResponse["status"]);

                    Console.WriteLine("\nReturn Admin District");
                    Console.WriteLine(singlePostJsonResponse["result"]["admin_district"]);

                    Console.WriteLine("\nUsing Classes");
                    var singlePostcodeObjectResponse = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content.ReadAsStringAsync().Result);
                    Console.WriteLine(singlePostcodeObjectResponse.status);
                    Console.WriteLine(singlePostcodeObjectResponse.result.region);

                    // Repeat with Bulkpostcode look up

                    //Console.WriteLine("Json Array of Objects");
                    ////Returning Specific item from Json object list
                    var bulkPostcodeJsonResponse = JObject.Parse(bulkPostcodeResponse.Content.ReadAsStringAsync().Result);
                    var adminDistrict = bulkPostcodeJsonResponse["result"][1]["result"]["admin_district"];
                    Console.WriteLine($"\nAdmin District of 2nd Post code {adminDistrict}");

                    Console.WriteLine("\nBulk Serialisation");

                    var bulkPostcodeObject = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkPostcodeResponse.Content.ReadAsStringAsync().Result);
                    Console.WriteLine(bulkPostcodeObject.status);
                    Console.WriteLine(bulkPostcodeObject.result[0].result.region);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }
    }
}