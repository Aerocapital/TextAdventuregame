using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;
using SimpleInventory;

namespace SimpleInventory
{
    public class Spieler
    {
        //Eigenschaften Des Spielers
        public string Name { get; }                // Name des Spielers
        public string Klasse { get; }               //Charakterklasse des Spielers

        //Attribute des Spielers
        public int Staerke { get; }                // Stärke des Spielers

        public int Intelligenz { get; }             // Intelligenz des Spielers

        public int AktuelleEbene { get; set; }          // 1 für Ebene1 2 für Ebene 2
        public int AktuellerRaumNummer { get; set; }   
        
        


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
            Name:   {Name}
            Klasse: {Klasse}
            Stärke: {Staerke}
            Intelligenz: {Intelligenz}");

            AktuelleEbene = 1;                  // Setze die aktuelle Ebene auf 1
            AktuellerRaumNummer = 1;            // Setze den aktuellen Raum auf 1


        }
        public void ZeigeStatus()
        {
            Console.WriteLine($"Name: {Name}, Klasse: {Klasse}, Stärke: {Staerke}, Intelligenz: {Intelligenz}");
        }

        // ToString() Methode für Statusanzeige
        public override string ToString()
        {
            return $"Name: {Name}\nKlasse: {Klasse}\nAttribute: \nStärke={Staerke}, \nIntelligenz={Intelligenz}\nFortschritt: Ebene {AktuelleEbene}, Raum {AktuellerRaumNummer}";
        }



    }

    
    

    


}


