using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.ApiClients
{
    public class RenommerFichierAudio
    {
        public static async Task Main()
        {
            var url = "https://api.voicepartner.fr/v1/audio-file/rename";
            var data = new
            {
                apiKey = "YOUR_API_KEY",
                tokenAudio = "TOKEN_DU_FICHIER_AUDIO",
                filename = "Nom du fichier"
            };

            using (var client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
