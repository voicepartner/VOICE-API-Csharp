using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.ApiClients
{
    public class CreditVoix
    {
        public static async Task Main()
        {
            var apiKey = "YOUR_API_KEY";
            var url = $"https://api.voicepartner.fr/v1/me/{apiKey}";

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(url);
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
