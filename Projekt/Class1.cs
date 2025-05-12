using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektInventory
{
    public class Spieler
    {
        //Eigenschaften Des Spielers
        public string Name { get; set; }                // Name des Spielers
        public string Klasse { get; set; }               //Charakterklasse des Spielers

        //Attribute des Spielers
        public int Staerke { get; set; }                // Stärke des Spielers

        public int Intelligenz { get; set; }            // Intelligenz des Spielers


        //Konstruktor wird beötigt wenn neuer Spieler erstellt wird
        public Spieler(string name, string klasse, int staerke, int intelligenz)
        {
            Name = name;
            Klasse = klasse;
            Staerke = staerke;
            Intelligenz = intelligenz;

            Console.WriteLine($"Ein neuer Spieler wurde ausgewählt:{Name} der Klasse {Klasse} (Stärke : {Staerke} % Intelligenz {Intelligenz})");
        }

        //Methode für Spieler Infos
        
        public void SpielerInfo()
            {
            Console.WriteLine($"Name{Name }");
            Console.WriteLine($"Klasse{Klasse}");
            Console.WriteLine($"Stärke{Staerke}");
            Console.WriteLine($"Intelligenz{Intelligenz}");
        }

    }
}
