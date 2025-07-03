using Lab12_TermCalc.Enums;

namespace Lab12_TermCalc.Logik
{
    public class Term
    {
        public string Eingabe { get; set; }
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }
        public Rechenoperation Operation => GetRechenoperation();

        // Konstruktoren sollten keine Logik enthalten, sondern nur die Initialisierung
        // sog. Code-Smell (https://de.wikipedia.org/wiki/Code-Smell)
        public Term(string term)
        {
            Eingabe = term;
        }

        // Method-Chaining: Wir geben unsere eigene Instanz zurueck, um Anweisungen verketten koennen
        public Term ParseEingabe()
        {
            //SplitTerm kann Null zurückgeben (führt bei Zugriff auf Array in nächster Zeile zu NullReferenceException)
            string[] zahlen = SplitTerm();

            if (zahlen.Length == 2)
            {
                //Parsing kann FormatExceptions und OverflowExceptions verursachen
                // mit string.Trim() entfernen wir whitespaces
                Zahl1 = int.TryParse(zahlen[0].Trim(), out var zahl1) ? zahl1 : 0;
                Zahl2 = int.TryParse(zahlen[1].Trim(), out var zahl2) ? zahl2 : 0;
            }

            return this;
        }

        public Rechenoperation GetRechenoperation()
        {
            if (!string.IsNullOrEmpty(Eingabe))
            {
                if (Eingabe.Contains('+'))
                    return Rechenoperation.Addition;
                else if (Eingabe.Contains('-'))
                    return Rechenoperation.Subtraktion;
                else if (Eingabe.Contains('*'))
                    return Rechenoperation.Multiplikation;
                else if (Eingabe.Contains('/'))
                    return Rechenoperation.Division;
            }

            // Besser eine InvalidOperationException werfen
            throw new InvalidOperationException("Operator unbekannt!");
        }

        public string[] SplitTerm()
        {
            switch (Operation)
            {
                case Rechenoperation.Addition:
                    return Eingabe.Split('+');
                case Rechenoperation.Subtraktion:
                    return Eingabe.Split('-');
                case Rechenoperation.Multiplikation:
                    return Eingabe.Split('*');
                case Rechenoperation.Division:
                    return Eingabe.Split('/');
            }
            return [];
        }
    }
}

