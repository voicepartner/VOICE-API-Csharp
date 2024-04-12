using Newtonsoft.Json;
using System.Text;

public class DeposerMessageVocal
{
    public static async Task Main()
    {
        var url = "https://api.voicepartner.fr/v1/campaign/send";

        // Définissez la date et l'heure manuellement ici
        //var scheduledDate = "2024-04-12 14:30:00"; // Format 'yyyy-MM-dd HH:mm:ss'
        //var sender = "VotreNumero"; // Remplacez par votre numéro de téléphone validé
        //var notifyUrl = "https://yourdomain.com/notify"; // Votre URL de notification

        var data = new
        {
            apiKey = "YOUR_API_KEY",
            tokenAudio = "TOKEN_AUDIO",
            emailForNotification = "email@example.com",
            phoneNumbers = "06xxxxxxxx",
            // Ajoutez d'autres paramètres optionnels si nécessaire
            //scheduledDate, // Pas besoin de AddHours, utilisez la valeur directement
            //sender, // Numéro de téléphone portable qui peut être rappelé
            //notifyUrl // URL de retour du statut de la campagne envoyée en GET
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
