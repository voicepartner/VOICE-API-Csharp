using System;

namespace API.ApiClients
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0].ToLower())
            {
                case "creditvoix":
                    CreditVoix.Main().Wait();
                    break;
                case "envoyersmsvocal":
                    EnvoyerSmsVocal.Main().Wait();
                    break;
                case "deposermessagevocal":
                    DeposerMessageVocal.Main().Wait();
                    break;
                case "listefichieraudio":
                    ListeFichierAudio.Main().Wait();
                    break;
                case "renommerfichieraudio":
                    RenommerFichierAudio.Main().Wait();
                    break;
                case "supprimeenvoidiffere":
                    SupprimeEnvoiDiffere.Main().Wait();
                    break;
                // Ajoutez des cases similaires pour les autres scripts
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }
    }
}
