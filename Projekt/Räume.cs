using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;                // Brauchen wir für Dictionary<>

namespace Projekt
{

    public class Raum
    {
        public string Name { get; }         //Name des Raums
        public string Beschreibung { get; }      //Beschreibung des raums

        //Dictionary speichert die Ausgänge des Raumes.
        // Der Schlüssel (string) ist die Himmelsrichtung (z.B. "norden", "osten").
        // Der Wert (Raum) ist das Raum-Objekt, das in diese Richtung liegt.
        private Dictionary<string, Raum> ausgaenge;

        public Raum(string name, string beschreibung)
        {
            Name = name;
            Beschreibung = beschreibung;
            ausgaenge = new Dictionary<string, Raum>();
        }
        // Methode, um einen Ausgang zu diesem Raum hinzuzufügen.
        // 'richtung' ist z.B. "norden", 'zielRaum' ist der Raum, zu dem dieser Ausgang führt.
        public void FuegeAusgangHinzu(string richtung, Raum zielRaum)
        {
            ausgaenge[richtung.ToLower()] = zielRaum;
        }

        // Methode, die den Raum in einer bestimmten Richtung zurückgibt.
        // Wenn in der Richtung kein Ausgang existiert, gibt sie null zurück.
        public Raum VerbundenerRaum(string richtung)
        {
            string normalisierteRichtung = richtung.ToLower();

            // Prüfen, ob der Schlüssel (die Richtung) im Dictionary existiert.
            if (ausgaenge.ContainsKey(normalisierteRichtung))
            {
                // Wenn der Schlüssel existiert, den Raum über den Indexer abrufen und zurückgeben.
                return ausgaenge[normalisierteRichtung];
            }
            else
            {
                // Wenn der Schlüssel nicht existiert, null zurückgeben.
                return null;
            }

            //---> nicht machbar ohne Grok, stunden verbracht
          
        }

        // Überschreibe ToString(), um eine Beschreibung des Raumes inklusive Ausgängen zu liefern.
        // Wir verwenden diese Methode, um den aktuellen Ort für den Spieler zu beschreiben.
        public override string ToString()
        {
            // Gibt einfach nur den Titel und die Beschreibung des Raumes zurück.
            // Die Informationen über die Ausgänge werden NICHT angezeigt.
            return $"--- Ort: {Name} ---\n{Beschreibung}";




        }

        // Verfügbare Ausgänge separat anzeigen --
        // Damit die Ausgänge angezeigt werden,

        public List<string> GetAusgangsRichtungen()
        {
            List<string> richtungenListe = new List<string>(); // Eine neue Liste für die Richtungen erstellen

            // Das Dictionary durchlaufen. Jeder Eintrag ist ein KeyValuePair (Schlüssel-Wert-Paar).
            foreach (KeyValuePair<string, Raum> ausgang in ausgaenge)
            {
                // Den Schlüssel (die Richtung als String) aus dem KeyValuePair holen
                string richtung = ausgang.Key;

                // Den Schlüssel zur Liste hinzufügen
                richtungenListe.Add(richtung);
            }

            return richtungenListe; // Die gefüllte Liste zurückgeben
        }
    }

}
