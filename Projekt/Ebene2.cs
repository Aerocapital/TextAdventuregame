using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;
using SimpleInventory;

namespace Projekt
{
    public class Ebene2
    {
        public Spieler spieler;

        public Ebene2(Spieler aktuellerSpieler)
        {
            spieler = aktuellerSpieler;
        }


        //Methode um auf Ebene 2 zu spielen
        //true wenn Ebene 2 abgeshclossen
        public bool SpieleEbene()
        { 
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=====BETRITT EBENE 2=====");
            Console.WriteLine("Du bist in der zweiten Ebene angekommen");
            Console.ResetColor();

            // Stelle sicher, dass der Spieler mit Raum 1 von Ebene 2 startet, falls er nicht schon weiter ist
            if (spieler.AktuelleEbene !=2 || spieler.AktuellerRaumNummer <1 || spieler.AktuellerRaumNummer > 3) // Ebene 2 hat 3 Räume
            {
                spieler.AktuelleEbene = 2;
                spieler.AktuellerRaumNummer = 1; // Startraum von Ebene 2
            }
            while (spieler.AktuellerRaumNummer <= 3 )
            { 
                //Raumbeschreibung
                ZeigeRaumBeschreibung(spieler.AktuellerRaumNummer);

                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1. Raum betreten");
                Console.WriteLine("2. Status anzeigen");
                Console.WriteLine("3. Ebene beenden (Frühzeitig)");
                Console.WriteLine("quit (Spiel beneden)");

                Console.WriteLine("BItte wähle eine Option (Nummer oder quit)");
                string eingabe = Console.ReadLine() ?? "";

                switch (eingabe)
                {
                    case "1":
                        if (spieler.AktuellerRaumNummer < 3) // Kann nur weitergehen, wenn nicht Raum 3, da Raum 3 Ende
                        {
                            spieler.AktuellerRaumNummer++;
                            Console.WriteLine("Du gehst weiter in den nächsten Raum...");
                            Console.ResetColor();
                        }
                        else
                        {
                            // Spieler ist bereits im letzten Raum
                            Console.WriteLine("Du kannst von hier aus nicht weiter gehen. Erkunde deine Umgebung oder beende die Ebene (Option 4).");
                            Console.ResetColor();
                        }
                        break;
                    case "2":                  //inventar kommt noch
                        spieler.SpielerInfo();
                        break;
                    case "3":
                        Console.WriteLine("===STATUS===");
                        Console.WriteLine(spieler);                 // ruft spieler.Tostring auf um status anzuzeigen
                        break;
                    case "4":
                        Console.WriteLine("Du hast die Ebene 2 vorzeitig beendet.");
                        return false; // Beende die Ebene vorzeitig
                    case "quit":
                        Console.WriteLine("Möchtest du das spiel wirklich beenden? (ja/nein)");
                        string spielQuit = Console.ReadLine().ToLower().Trim();
                        if (spielQuit == "ja")
                        {
                            Console.WriteLine("Das Spiel wird beendet. Auf Wiedersehen!");
                            return true; // Beende das Spiel
                        }
                        else
                        {
                            Console.WriteLine("Das Spiel wird fortgesetzt.");
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe, tippe (´1´, ´2´,´3´,´4´ oder ´quit´) ");
                        Console.ResetColor();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== Ende Ebene2 ===");
                Console.ResetColor();

            }
            return true;                // Spieler hat die Ebene 2 erfolgreich abgeschlossen
        }
        private void ZeigeRaumBeschreibung(int raumNummer)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"\n--- Ebene 1, Raum {raumNummer} ---");
            Console.ResetColor();

            switch (raumNummer)
            {
                case 1:
                    Console.WriteLine("Du bist in einem Raum mit einem großen Tisch und vielen alten Büchern.");
                    break;
                case 2:
                    Console.WriteLine("Du bist in einem Raum mit einem großen Fenster, durch das du die Landschaft sehen kannst.");
                    break;
                case 3:
                    Console.WriteLine("Du bist in einem Raum mit einer geheimen Tür, die zu einem verborgenen Schatz führt.");
                    break;
                default:
                    Console.WriteLine("Unbekannter Raum.");
                    break;
            }
        }
    }
}
