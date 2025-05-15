using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;
using SimpleInventory;





namespace Projekt 
{
  
    public class Ebene1
    {
        // Eine Referenz auf das Spieler-Objekt.
        public Spieler spieler;

        public bool kisteInRaum2Geoeffnet = false;

        // Konstruktor: Eine Ebene braucht das Spieler-Objekt.
        public Ebene1(Spieler aktuellerSpieler)
        {
            spieler = aktuellerSpieler;
        }

        // Methode, um Ebene 1 zu "spielen".
        // Gibt true zurück, wenn Ebene 1 erfolgreich abgeschlossen wurde .
        
        public bool SpieleEbene()
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("=====BETRITT EBENE 1====="); 
            Console.WriteLine("Das Abenteuer beginnt"); 
            Console.ResetColor();

            // Stelle sicher, dass der Spieler mit Raum 1 von Ebene 1 startet, falls er nicht schon weiter ist
            if (spieler.AktuelleEbene != 1 || spieler.AktuellerRaumNummer < 1 || spieler.AktuellerRaumNummer > 3) // Ebene 1 hat 3 Räume
            {
                spieler.AktuelleEbene = 1;
                spieler.AktuellerRaumNummer = 1; // Startraum von Ebene 1
            }


            // Schleife für die Räume in dieser Ebene (von Raum 1 bis 3)
            // Die Schleife läuft, solange der Spieler sich in den Räumen 1 bis 3 befindet.
            while (spieler.AktuellerRaumNummer <= 3) // Ebene 1 hat 3 Räume
            {
                
                ZeigeRaumBeschreibung(spieler.AktuellerRaumNummer);


                
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("1. Raum betreten"); 
                Console.WriteLine("2. Inventar anzeigen"); 
                Console.WriteLine("3. Status anzeigen");

                //Option Kiste einfügen
                if (spieler.AktuellerRaumNummer == 2 && !kisteInRaum2Geoeffnet) // Wenn Spieler im Raum 2 ist und die Kiste noch nicht geöffnet wurde
                {
                    Console.WriteLine("4. Kiste öffnen");
                }

                Console.WriteLine("5. Ebene beenden (Frühzeitig)");             // Klarstellen, dass es frühzeitig ist
                Console.WriteLine("quit (Spiel komplett beenden)"); 

                

                Console.WriteLine("Bitte wähle eine Option (1, 3, 4 oder 'quit'): "); 
                string eingabe = Console.ReadLine().ToLower().Trim() ?? "";                      // Eingabe lesen
                                           

                switch (eingabe)
                {
                    case "1":                           // Raum betreten 
                                
                        if (spieler.AktuellerRaumNummer < 3)                // Kann nur weitergehen, wenn nicht Raum 3, da Raum 3 Ende
                        {
                            spieler.AktuellerRaumNummer++;                      // Erhöhe die Raum-Nummer des Spielers
                            Console.WriteLine("Du gehst weiter in den nächsten Raum...");
                            Console.ResetColor();

                            // Die Schleife wiederholt sich und zeigt den nächsten Raum an
                        }
                        else
                        {
                            // Spieler ist bereits im letzten Raum
                            
                            Console.WriteLine("Du kannst von hier aus nicht weiter gehen. Erkunde deine Umgebung oder beende die Ebene (Option 4)."); // Angepasster Text
                            Console.ResetColor();

                        }
                        break; 

                    case "2":                                                               // Raum verlassen 

                        spieler.ZeigeInventar(); 
                        break;
                         

                    case "3":      
                                                                                // Status anzeigen
                        Console.WriteLine("\n--- Charakterstatus ---");
                        Console.WriteLine(spieler);                         // Ruft spieler.ToString() auf
                        Console.ResetColor();
                        break;

                    case "4":
                        if (spieler.AktuellerRaumNummer == 2 && !kisteInRaum2Geoeffnet)
                        {
                            Console.WriteLine("Eine rostige Kiste steht mitten im Raum");

                            Console.WriteLine("\n Möchtest du Sie öffnen? (ja/nein)");
                            string kisteOeffnen = Console.ReadLine()?.ToLower().Trim() ?? ""; // Eingabe lesen und formatieren

                            if (kisteOeffnen == "ja")
                            {
                                Heiltrank gefundenerTrank = new Heiltrank("Heiltrank", "Ein Trank, der deine Gesundheit wiederherstellt.", 20); // Erstelle einen neuen Heiltrank

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Du öffnest die Kiste und findest einen Heiltrank");
                                Console.ResetColor();

                                spieler.GegenstandHinzufuegen(gefundenerTrank); // Füge den Heiltrank dem Inventar des Spielers hinzu

                                kisteInRaum2Geoeffnet = true; // Setze die Kiste als geöffnet
                            }
                            else { Console.WriteLine("Du gehst an der Kiste vorbei"); }     //Kiste wird nicht geöffnet
                        }
                        break;

                    case "5":                                                           // Ebene frühzeitig beenden
                        Console.WriteLine("Möchtest du Ebene 1 wirklich frühzeitig beenden? (ja/nein)");
                        string sicherheit = Console.ReadLine()?.ToLower().Trim() ?? "";
                        if (sicherheit == "ja" || sicherheit == "j")
                        {
                            Console.WriteLine("Du verlässt Ebene 1.");
                            return true; 
                        }
                        else
                        {
                            Console.WriteLine("Du bleibst auf Ebene 1.");
                        }
                        break; 

                    case "quit":                                                                // Spiel komplett beenden
                        Console.WriteLine("Möchtest du das Spiel komplett beenden? (ja/nein)");
                        string frueherQuitten = Console.ReadLine()?.ToLower().Trim() ?? "";
                        if (frueherQuitten == "ja" )
                        {
                            Console.WriteLine("Das Spiel wird beendet.");
                            return false;                                       // Gibt false zurückum  das Spiel zu beenden
                        }
                        else
                        {
                            Console.WriteLine("Du bleibst im Spiel.");
                        }
                        break; 


                    

                    default:
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Nummer aus dem Menü oder tippe 'quit'.");
                        Console.ResetColor();
                        break; //
                } 

                
            } 

           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--- ENDE EBENE 1 ERREICHT ---");
            Console.ResetColor();

            
            Console.WriteLine("Du erreichst das Ende von Ebene 1 und triffst auf einen Gegner!");
            // Hier wird das Schere-Stein-Papier Minispiel aufgerufen 

            return true; // Gibt true zurück, Ebene 1 erfolgreich 
        } 

        // Private Methode, um die Beschreibung basierend auf der Raum-Nummer anzuzeigen.
        
        private void ZeigeRaumBeschreibung(int raumNummer)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Console.WriteLine($"\n--- Ebene 1, Raum {raumNummer} ---");
            Console.ResetColor();

            switch (raumNummer)
            {
                case 1:
                    Console.WriteLine("Du betrittst eine feuchte Höhle. Es riecht nach Moos.");
                    
                    Console.WriteLine("Wenn du weiter gehst, wird es modriger und dunkler, sodass es schwerer wird, dich zurechtzufinden.");
                    break;
                case 2:
                    Console.WriteLine("Der Gang wird enger und dunkler. Seltsame Geräusche sind zun hören.");
                    
                    Console.WriteLine("Wenn du weiter gehst, wird es noch modriger und dunkler, sodass es noch schwerer wird, dich zurechtzufinden.");
                    break;
                case 3:
                    Console.WriteLine("Du kriechst durch einen sehr engen Tunnel. Die Luft ist stickig. Vor dir siehst du ein schwaches Licht.");
                    Console.WriteLine("Dies scheint der letzte Raum von Ebene 1 zu sein."); 
                    break;
                default:
                   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler: Unbekannte Raumnummer auf Ebene 1.");
                    Console.ResetColor();
                    break;
            }
        }

        // Später kommen hier Methoden für den Endgegner etc.
    } 
} 