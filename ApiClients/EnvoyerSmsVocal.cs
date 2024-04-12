using Newtonsoft.Json;
using System.Text;

public class EnvoyerSmsVocal
{
    public static async Task Main()
    {
        var url = "http://api.voicepartner.fr/v1/tts/send";
        //var scheduledDate = "2024-04-12 10:30:00"; // Format 'yyyy-MM-dd HH:mm:ss'

        var data = new
        {
            apiKey = "YOUR_API_KEY",
            text = "Votre texte ici",
            phoneNumbers = "06XXXXXXXX",
            // Ajoutez d'autres paramètres optionnels si nécessaire
            //lang = "fr", // Supposons que nous envoyons en français
            //speechRate = 1.0, // La vitesse par défaut est 1
            //notifyUrl = "https://yourdomain.com/notify",
            //scheduledDate
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
