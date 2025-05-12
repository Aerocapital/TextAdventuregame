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
        public string Name { get;  }                // Name des Spielers
        public string Klasse { get;  }               //Charakterklasse des Spielers

        //Attribute des Spielers
        public int Staerke { get;  }                // Stärke des Spielers

        public int Intelligenz { get;  }            // Intelligenz des Spielers


        //Konstruktor wird beötigt wenn neuer Spieler erstellt wird
        public Spieler(string name, string klasse, int staerke, int intelligenz)
        {
            Name = name;
            Klasse = klasse;
            Staerke = staerke;
            Intelligenz = intelligenz;

            Console.WriteLine($"Ein neuer Spieler wurde ausgewählt:\n{Name} der Klasse {Klasse}, \n(Stärke : {Staerke},  \nIntelligenz {Intelligenz})");
        }

        //Methode für Spieler Infos
        
        public void SpielerInfo()
        {
            Console.WriteLine(@$"
            Name:   {Name }
            Klasse: {Klasse}
            Stärke: {Staerke}
            Intelligenz: {Intelligenz}");
            
            
        }

    }
}
