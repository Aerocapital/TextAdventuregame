using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Heiltrank : Gegenstand                 //kindsklasse
    {
        public int Heilungswert { get; set; } // Wert, um den die Gesundheit des Spielers erhöht wird

        public Heiltrank(string name, string beschreibung, int heilungswert) : base(name, beschreibung)
        {
            Heilungswert = heilungswert;
        }

        public void Benutzen()
        {
            Console.WriteLine($"du trinkst den {Name}.Du fühlst dich direkt besser");
        }
        public override string ToString()
        {
            return $"{Name}, Heilungswert: {Heilungswert}";
        }
    }
}
