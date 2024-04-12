using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.ApiClients
{
    public class SupprimeEnvoiDiffere
    {
        public static async Task Main()
        {
            var apiKey = "YOUR_API_KEY";
            var campaignId = "CAMPAIGN_ID";
            var url = $"https://api.voicepartner.fr/v1/campaign/cancel/{apiKey}/{campaignId}";

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.DeleteAsync(url);
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
