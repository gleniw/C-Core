using System.Net.Http;

namespace APIClientHTTP
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient()) // IDisposable interface
            {
                var singlePostcodeRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Get //Get by default
                };

                singlePostcodeRequest.Headers.Add("Accept", "application/json");
                var postcode = "EC2Y 5AS";
                singlePostcodeRequest.RequestUri = new Uri($"https://api.postcodes.io/postcodes/{postcode}");

                try
                {
                    Console.WriteLine("Response");
                    HttpResponseMessage singlePostcodeResponse = await client.SendAsync(singlePostcodeRequest);
                    Console.WriteLine(singlePostcodeResponse.Content.ReadAsStringAsync().Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                // Take this single response and get the status code and headers e.g. Date
                // Serialise to a JObject (need to install Newtonsoft)
                // Query JObject examples
                // Repeat with Bulkpostcode look up
            }
        }
    }
}