using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;

namespace Projekt
{
    internal class SchereSteinPapier
    {
        static string[] optionen = { "Schere", "Stein", "Papier" };
        static Random random = new Random();

        public static bool SpieleSchereSteinPapier()  //Bool um zu sehen ob spieler gewonnen oder verloren hat
        {
            Console.WriteLine("\n--- Mini-Spiel: Schere, Stein, Papier ---");
            Console.WriteLine("Wähle: 1 = Schere | 2 = Stein | 3 = Papier");

            
            while (true)
            {
                Console.Write("Deine Wahl: ");
                string eingabe = Console.ReadLine()?.Trim() ?? "";

                
                if (!int.TryParse(eingabe, out int spielerWahl) || spielerWahl < 1 || spielerWahl > 3)
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte wähle 1, 2 oder 3.");
                    
                    continue; 
                }

                int computerWahl = random.Next(1, 4); 

                string spielerZug = optionen[spielerWahl - 1];
                string computerZug = optionen[computerWahl - 1];

                
                Console.WriteLine("\n--- Ergebnis ---");
                Console.WriteLine($"Du wählst: {spielerZug}"); 
                Console.WriteLine($"Endgegner wählt: {computerZug}"); 
                Console.WriteLine("----------------");

                

                if (spielerWahl == computerWahl)
                {
                    
                    Console.WriteLine("Unentschieden! Spiele noch eine Runde.");
                    
                    
                }
                else if ((spielerWahl == 1 && computerWahl == 3) || // Schere schlägt Papier
                         (spielerWahl == 2 && computerWahl == 1) || // Stein schlägt Schere
                         (spielerWahl == 3 && computerWahl == 2))  // Papier schlägt Stein
                {
                     
                    Console.WriteLine("Du gewinnst!");
                    
                    return true; // Spieler gewinnt das Minispiel
                }
                else
                {
                    
                    Console.WriteLine("Du verlierst!");
                    
                    return false; // Spieler verliert das Minispiel
                }
            }
        }
    }
}

