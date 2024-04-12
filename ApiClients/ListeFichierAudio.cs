using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.ApiClients
{
    public class ListeFichierAudio
    {
        public static async Task Main()
        {
            var url = "http://api.voicepartner.fr/v1/audios/YOUR_API_KEY";

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
