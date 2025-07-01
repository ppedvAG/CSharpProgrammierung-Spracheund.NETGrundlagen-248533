namespace Lab9_CountTypes.Fahrzeugpark
{
    //vgl. Schiff
    public class Auto : FahrzeugBase
    {
        public int AnzahlTueren { get; set; }

        public Auto(string name, int maxG, double preis, int anzTueren) : base(name, maxG, preis)
        {
            AnzahlTueren = anzTueren;
        }

        public override string Info()
        {
            return "Der PKW " + base.Info() + $" Er hat {AnzahlTueren} Türen.";
        }

        public override void Hupen()
        {
            Console.WriteLine($"{Name}: 'Hup Hup'");
        }
    }
}