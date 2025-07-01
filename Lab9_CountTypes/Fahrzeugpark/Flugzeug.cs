namespace Lab9_CountTypes.Fahrzeugpark
{
    //vgl. Schiff
    public class Flugzeug : FahrzeugBase
    {
        public int MaxFlughöhe { get; set; }

        public Flugzeug(string name, int maxG, double preis, int maxFH) : base(name, maxG, preis)
        {
            MaxFlughöhe = maxFH;
        }

        public override string Info()
        {
            return "Das Flugzeug " + base.Info() + $" Es kann bis auf {MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupen()
        {
            Console.WriteLine($"{Name}: 'Biep Biep'");
        }
    }
}