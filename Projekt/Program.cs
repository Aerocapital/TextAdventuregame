using SimpleInventory;
using Projekt;
using System.Runtime.CompilerServices;

class Programm
{
    static Spieler spielerCharakter;

    Spieler spieler = null;



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
        int anfangsStaerke = 1 ;                //Standartstaerke
        int anfangsIntelligenz = 1;            //Standartintelligenz

        bool charakterwahl = false;    // Variable für die Charakterwahl
        while (!charakterwahl)
        {
            Console.WriteLine("Wähle deine Klasse: ");
            Console.WriteLine("1. Krieger");
            Console.WriteLine("2. Magier");
            Console.WriteLine("3. Bauer");
            Console.WriteLine("Bitte gib die Nummer deiner Wahl ein: ");                //Nachträglich eingesetzt da schöner in der Konsole
            string eingabe = Console.ReadLine()?? "";
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
            Console.WriteLine("Bitte nenne mir deinen Namen, Held von Ozelot: ");

            string spielerName = Console.ReadLine()?? "";

            Console.WriteLine($"\nDu hast dich für {ausgewaehlteKlasse} entschieden");

            Spieler spielerCharakter = new Spieler(spielerName, ausgewaehlteKlasse, anfangsStaerke, anfangsIntelligenz); // Erstelle ein Spieler-Objekt mit den gewählten Eigenschaften



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====DEIN ABENTEUER VON OZELOT BEGINNT=====");
            Console.ResetColor();
            Console.WriteLine();

            bool ebene1Erfolgreich = false;  // Flag für den Erfolg der ersten Ebene

            bool spielLaeuft = true;          // Flag für den Spielstatus

            // Start Ebene 1 ---

            spielerCharakter.AktuelleEbene = 1;
            spielerCharakter.AktuellerRaumNummer = 1;
            Ebene1 ebene1 = new Ebene1(spielerCharakter);               // Erstelle ein Objekt der Klasse Ebene1
            
            ebene1Erfolgreich = ebene1.SpieleEbene();                   //gibt true zurück, wenn Ebene 1 geschafft/beendet ist, false bei 'quit'.


            if (ebene1Erfolgreich && spielerCharakter.AktuellerRaumNummer > 3)
            {
                Console.WriteLine("\nDu hast Ebene 1 gemeistert! Du steigst tiefer in den Berg.");
                
                spielerCharakter.AktuelleEbene = 2;                     // Setze Spieler auf Startposition für Ebene 2
                spielerCharakter.AktuellerRaumNummer = 1;               // Setze Spieler auf Raum 1 von Ebene 2

                // Starte Ebene 2
                Ebene2 ebene2 = new Ebene2(spielerCharakter);           // Erstelle ein Objekt der Klasse Ebene2
                bool ebene2Erfolgreich = ebene2.SpieleEbene();          // wenn true läuft Spiel weiter

                
                
                if (ebene2Erfolgreich && spielerCharakter.AktuellerRaumNummer > 3)
                {
                    Console.WriteLine("Du hast auch Ebene 2 gemeistert!");
                    Console.WriteLine("Dein Abenteuer in Ozelot ist vorerst abgeschlossen."); // Platzhalter
                    spielLaeuft = false; // Spielende nach Ebene 2
                }
                else
                {
                    
                    Console.WriteLine("Du hast Ebene 2 nicht gemeistert! Spiel Ende");         //// Ebene 2 nicht erfolgreich (quit) oder frühzeitig beendet
                    spielLaeuft = false; 
                }
            }
            else
            {
                
                Console.WriteLine("Das Spiel wird beendet.");
                spielLaeuft = false; 
            }


            
            Console.WriteLine("\nDas Abenteuer endet hier. Drücke eine Taste zum Schließen.");
            Console.ReadKey();


           

        } 
    }
    

}
    
   

    
  
    
    

    
