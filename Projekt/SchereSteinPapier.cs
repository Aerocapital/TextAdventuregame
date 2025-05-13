using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SchereSteinPapier
    {
        static string[] optionen = { "Schere", "Stein", "Papier" };
        static Random random = new Random();

        public static void SpieleSchereSteinPapier()
        {
            Console.WriteLine("\n--- Mini-Spiel: Schere, Stein, Papier ---");
            Console.WriteLine("Wähle: 1 = Schere | 2 = Stein | 3 = Papier");
            Console.Write("Deine Wahl: ");
            string eingabe = Console.ReadLine() ?? "";

            if (!int.TryParse(eingabe, out int spielerWahl) || spielerWahl < 1 || spielerWahl > 3)
            {
                Console.WriteLine("Ungültige Eingabe!");
                return;
            }

            int computerWahl = random.Next(1, 4);

            string spielerZug = optionen[spielerWahl - 1];
            string computerZug = optionen[computerWahl - 1];

            Console.WriteLine($"Du hast {spielerZug} gewählt.");
            Console.WriteLine($"Der Gegner hat {computerZug} gewählt.");

            if (spielerWahl == computerWahl)
            {
                Console.WriteLine("Unentschieden!");
            }
            else if ((spielerWahl == 1 && computerWahl == 3) ||
                     (spielerWahl == 2 && computerWahl == 1) ||
                     (spielerWahl == 3 && computerWahl == 2))
            {
                Console.WriteLine("Du gewinnst!");
            }
            else
            {
                Console.WriteLine("Du verlierst!");
            }
        }
    }
}

