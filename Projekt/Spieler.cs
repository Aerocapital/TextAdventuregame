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
        
        public string Name { get; }
        public string Klasse { get; }

        
        public int Staerke { get; }
        public int Intelligenz { get; }

        
        public int AktuelleEbene { get; set; }
        public int AktuellerRaumNummer { get; set; }

        // Das Inventar des Spielers.
        // Eine Liste von Gegenstand-Objekten. Da Heiltrank von Gegenstand erbt,
        
        public List<Gegenstand> Inventar { get; } 


        // --- Konstruktor ---
        // Wird beim Erstellen des Spieler-Objekts aufgerufen.
        public Spieler(string name, string klasse, int staerke, int intelligenz)
        {
            Name = name;
            Klasse = klasse;
            Staerke = staerke;
            Intelligenz = intelligenz;

            //  Start von Ebene 1, Raum 1
            AktuelleEbene = 1;
            AktuellerRaumNummer = 1;

            
            Inventar = new List<Gegenstand>(); 
        }

        

       
        public void GegenstandHinzufuegen(Gegenstand item)
        {
            Inventar.Add(item); // Fügt den Gegenstand dem Inventar des Spielers hinzu
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"{Name} hat '{item.Name}' zum Inventar hinzugefügt."); // Nutzt item.Name (geerbte Eigenschaft)
            Console.ResetColor();
        }

        // Methode, um das Inventar anzuzeigen.
        public void ZeigeInventar()
        {
            Console.WriteLine($"\n--- Inventar von {Name} ---"); 
            if (Inventar.Count == 0)
            {
                Console.WriteLine("Dein Rucksack ist leer."); 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; 
                foreach (Gegenstand item in Inventar)
                {
                    // Ruft item.ToString() auf )
                    Console.WriteLine($" {item}");
                }
                Console.ResetColor(); 
            }
           

        }


        
        public override string ToString()
        {
            
            return $"Name: {Name}\nKlasse: {Klasse}\nAttribute: \nStärke={Staerke}, \nIntelligenz={Intelligenz}\nFortschritt: Ebene {AktuelleEbene}, Raum {AktuellerRaumNummer}\nInventarplätze: {Inventar.Count}";
        }

        
    }







}


