using ProjektInventory;

class Programm
{
    static Spieler spielerCharakter;
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("======================================");
        Console.WriteLine("Willkommen In der Welt von  Ozelot!");
        Console.WriteLine("======================================");

        Console.ResetColor();

        Console.WriteLine("Eine dunkle Bedrohung nähert sich Ozelot");
        Console.WriteLine("Ein Held wird gesucht um die Bürger und Ländereien zu verteidigen");

        Console.WriteLine("Bevor das Abenteuer beginnt, wähle deine Helden: ");

        string ausgewaehlteKlasse = "Bauer";        //Standartklasse
        int anfangsStaerke = 1;                //Standartstaerke
        int anfangsIntelligenz = 1;            //Standartintelligenz

        bool charakterwahl = false;    // Variable für die Charakterwahl
        while (!charakterwahl)
        {
            Console.WriteLine("Wähle deine Klasse: ");
            Console.WriteLine("1. Krieger");
            Console.WriteLine("2. Magier");
            Console.WriteLine("3. Bauer");
            Console.WriteLine("Bitte gib die Nummer deiner Wahl ein: ");                //Nachträglich eingesetzt da schöner in der Konsole
            string eingabe = Console.ReadLine();
            switch (eingabe)
            {
                case "1":
                    ausgewaehlteKlasse = "Krieger";
                    anfangsStaerke = 10;
                    anfangsIntelligenz = 5;
                    charakterwahl = true;
                    break;
                case "2":
                    ausgewaehlteKlasse = "Magier";
                    anfangsStaerke = 5;
                    anfangsIntelligenz = 10;
                    charakterwahl = true;
                    break;
                case "3":
                    ausgewaehlteKlasse = "Bauer";
                    anfangsStaerke = 1;
                    anfangsIntelligenz = 1;
                    charakterwahl = true;
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe, bitte wähle eine gültige Klasse.");
                    break;
            }
            
        }
        Console.WriteLine($"\nDu hast dich fpr {ausgewaehlteKlasse} entschieden");

        Console.WriteLine("Bitte nenne mir deinen Namen, Held von Ozelot: ");

        string spielerName = Console.ReadLine();

        if (string.IsNullOrEmpty(spielerName))              //IsnullorEMpty vorgabe von visual studio
        {
            Console.WriteLine($"Du bist fortan bekannt als {spielerName} );");
            spielerName = "Helz von Ozelot"; // Standardname
        }

        // --- Spieler-Objekt erstellen ---
        // Jetzt erstellen wir das Spieler-Objekt mit den gesammelten Infos
        spielerCharakter = new Spieler(spielerName, ausgewaehlteKlasse, anfangsStaerke, anfangsIntelligenz);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nDein Abenteuer in Azeria beginnt, Held!");
        Console.ResetColor();
        Console.WriteLine("--------------------------------------------------");


    }
}