using SimpleInventory;
using Projekt;

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
                    Console.WriteLine("Ungültige Eingabe, bitte wähle eine gültige Klasse");
                    break;
            }
            
        }
        Console.WriteLine($"\nDu hast dich fpr {ausgewaehlteKlasse} entschieden");

        Console.WriteLine("Bitte nenne mir deinen Namen, Held von Ozelot: ");

        string spielerName = Console.ReadLine();

        if (string.IsNullOrEmpty(spielerName))              
        {
            Console.WriteLine($"Du bist fortan bekannt als {spielerName} );");
            spielerName = "Helz von Ozelot"; // Standardname                        //Dies hat Grok verbessert
        }

        // --- Spieler-Objekt erstellen ---
        // Jetzt erstellen wir das Spieler-Objekt mit den gesammelten Infos
        spielerCharakter = new Spieler(spielerName, ausgewaehlteKlasse, anfangsStaerke, anfangsIntelligenz);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nDein Abenteuer in Azeria beginnt, Held!");
        Console.ResetColor();
        Console.WriteLine("--------------------------------------------------");


        
        //Haupotschleife

        while (true)                    //Läuft bis breat oder return
        { 
        Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("---Modrige Höhle---");
            Console.ResetColor();
            Console.WriteLine("Du bist in einer modrigen Höhle, die Wände sind feucht und es riecht nach Oma.");
            Console.WriteLine("Vor dir siehst du einen Weg, der nach links und einen nach rechts führt.");

            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("1. Nach links gehen");
            Console.WriteLine("2. Nach rechts gehen");
            Console.WriteLine("3. Geradeaus gehen");
            string befehl = Console.ReadLine();
            befehl = befehl.ToLower().Trim();              // nachträglich geändert da sonst immmr eingabefehler gehabt


            //Befehl verarbeiten, mit platzhalter da morgen inventar etc
            switch (befehl)
            {
                case "quit":
                case "beenden":                             //wenn man keine Bock mehr hat
                    Console.WriteLine("Wenn du beendest, stirbst du, willst du sterben = (ja/nein) ");
                    string sicherheit = Console.ReadLine().ToLower().Trim();
                    if (sicherheit == "ja" || sicherheit == "j")
                    {
                        Console.WriteLine("Du elende Pfeife lässt alle im Stich");
                            return;
                    }
                    else
                    {
                        Console.WriteLine("Auch wahren Helden geht anfangs die Muffe");
                    }
                    break;
                case "status":                              //zeigt Spielerstatus
                    spielerCharakter.ZeigeStatus();
                    break; 
                case "inventar":                            //zeigt Inventar, Inventarliste wird noch erstellt
                    Console.WriteLine("Dein rucksack beinhaltet:");
                    break;

                case "schere stein papier":                 //Minispiel
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Was soll dieser Befehl bedeuten?");
                    break;



                   
            }
        }


    }
   

    
  
    
    }

    

}