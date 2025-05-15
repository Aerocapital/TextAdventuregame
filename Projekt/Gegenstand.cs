using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Gegenstand             //elternklasse
    {
        public string Name { get; set; }                    // Name des Gegenstands
        public string Beschreibung { get; set; }                // Beschreibung des Gegenstands

        public Gegenstand(string name, string beschreibung)
        {
            Name = name;
            Beschreibung = beschreibung;
        }
        // Überschreibe ToString(), um eine einfache Textdarstellung des Gegenstands zu liefern.
        // Wird standardmäßig genutzt, wenn Console.WriteLine(gegenstandObjekt) gemacht wird.

        //wurde mir gesagt hatte ich vergessen (CURSOR)
        public override string ToString()
        {
            return $"{Name}: {Beschreibung}";
        }
    }
}
