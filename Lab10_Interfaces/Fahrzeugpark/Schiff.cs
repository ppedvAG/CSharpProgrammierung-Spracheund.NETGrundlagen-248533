namespace Fahrzeugpark
{
    // Aufgabe 2: Interface implementieren
    public class Schiff : FahrzeugBase, IBeladbar
    {
        //Klasseneigener Enum
        public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

        //Klasseneigene Property
        public SchiffsTreibstoff Treibstoff { get; set; }

        public FahrzeugBase Ladung { get; set; }

        //Konstruktor mit Bezug auf den Konstruktor der Mutterklasse (base)
        public Schiff(string name, int maxG, double preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
        }

        //Überschreibung der Info()-Methode mit Bezug auf die Methode der Mutterklasse (base)
        public override string Info()
        {
            var info = "Das Schiff " + base.Info() + $" Es fährt mit {this.Treibstoff}";
            if (Ladung != null)
            {
                info += $" und transportiert {Ladung.Name}";
            }

            return info + ". ";
        }

        //Durch Mutterklasse verlangter Member (da dort als abstract gesetzt)
        public override void Hupen()
        {
            Console.WriteLine($"{this.Name}: 'Tröööt'");
        }

        public bool Belade(FahrzeugBase fahrzeug)
        {
            // Ein Fahrzeug kann sich nicht selber transportieren
            if (this == fahrzeug)
            {
                Console.WriteLine("Das Fahrzeug kann sich nicht selber transportieren.");
                return false;
            }
            // Wenn die Eigenschaft "leer" ist
            else if (Ladung == null)
            {
                Ladung = fahrzeug;
                Console.WriteLine($"Ladevorgang von {fahrzeug.Name} auf {Name} erfolgreich.");
                return true;
            }
            else
            {
                Console.WriteLine($"Ladeplatz auf {Name} bereits durch {Ladung.Name} belegt.");
                return false;
            }
        }

        public FahrzeugBase Entlade()
        {
            // Pruefung ob Ladung vorhanden ist
            if (Ladung != null)
            {
                // Ladung zwischenspeichern
                var ausgabe = Ladung;
                // Ladung entfernen
                Ladung = null;
                // Erfolgsmeldung
                Console.WriteLine($"Entladevorgang von {ausgabe.Name} von {Name} erfolgreich.");
                return ausgabe;
            }

            // Fehlermeldung
            Console.WriteLine($"{Name} hat keine Ladung geladen.");
            return null;
        }
    }
}