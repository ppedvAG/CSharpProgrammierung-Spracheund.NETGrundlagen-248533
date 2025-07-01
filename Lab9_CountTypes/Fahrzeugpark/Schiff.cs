namespace Lab9_CountTypes.Fahrzeugpark
{
    //Schiff erbt von der Fahrzeug-Klasse und übernimmt deren Member
    public class Schiff : FahrzeugBase
    {
        //Klasseneigener Enum
        public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

        //Klasseneigene Property
        public SchiffsTreibstoff Treibstoff { get; set; }

        //Konstruktor mit Bezug auf den Konstruktor der Mutterklasse (base)
        public Schiff(string name, int maxG, double preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
        {
            Treibstoff = treibstoff;
        }

        //Überschreibung der Info()-Methode mit Bezug auf die Methode der Mutterklasse (base)
        public override string Info()
        {
            return "Das Schiff " + base.Info() + $" Es fährt mit {Treibstoff}.";
        }

        //Durch Mutterklasse verlangter Member (da dort als abstract gesetzt)
        public override void Hupen()
        {
            Console.WriteLine($"{Name}: 'Tröööt'");
        }
    }
}