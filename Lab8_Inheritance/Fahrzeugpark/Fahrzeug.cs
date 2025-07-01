namespace Lab8_Inheritance.Fahrzeugpark
{
    public class Fahrzeug
    {
        //Felder
        private bool _motorLäuft = false;
        private int _aktGeschwindigkeit = 0;

        //Properties
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public double Preis { get; set; }

        //Konstruktor mit Übergabeparametern und Standartwerten
        public Fahrzeug(string name, int maxG, double preis)
        {
            Name = name;
            MaxGeschwindigkeit = maxG;
            Preis = preis;
            _aktGeschwindigkeit = 0;
            _motorLäuft = false;
        }

        //Methode zur Ausgabe von Objektinformationen
        public virtual string Info()
        {
            if (_motorLäuft)
                return $"{Name} kostet {Preis}€ und fährt momentan mit {_aktGeschwindigkeit} von maximal {MaxGeschwindigkeit}km/h.";
            else
                return $"{Name} kostet {Preis}€ und könnte maximal {MaxGeschwindigkeit}km/h fahren.";
        }

        //Methode zum Starten des Motors
        public void StarteMotor()
        {
            if (_motorLäuft)
                Console.WriteLine($"Der Motor von {Name} läuft bereits.");
            else
            {
                _motorLäuft = true;
                Console.WriteLine($"Der Motor von {Name} wurde gestartet.");
            }
        }

        //Methode zum Stoppen des Motors
        public void StoppeMotor()
        {
            if (!_motorLäuft)
                Console.WriteLine($"Der Motor von {Name} ist bereits gestoppt");
            else if (_aktGeschwindigkeit > 0)
                Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {Name} noch bewegt");
            else
            {
                _motorLäuft = false;
                Console.WriteLine($"Der Motor von {Name} wurde gestoppt.");
            }
        }

        //Methode zum Beschleunigen und Bremsen
        public void Beschleunige(int a)
        {
            if (_motorLäuft)
            {
                if (_aktGeschwindigkeit + a > MaxGeschwindigkeit)
                    _aktGeschwindigkeit = MaxGeschwindigkeit;
                else if (_aktGeschwindigkeit + a < 0)
                    _aktGeschwindigkeit = 0;
                else
                    _aktGeschwindigkeit += a;

                Console.WriteLine($"{Name} bewegt sich jetzt mit {_aktGeschwindigkeit}km/h");
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
