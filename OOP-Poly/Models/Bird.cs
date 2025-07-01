// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
namespace OOP_Poly.Models
{
    public class Bird : CreatureBase
    {
        public int WingSpanInCm { get; }

        public Bird(string name, int wingSpanInCm)
            // Wir rufen den Konstruktor der Basisklasse auf
            : base(name, 0)
        {
            WingSpanInCm = wingSpanInCm;
        }

        public void Fly() 
        {
            // Wir koennen nicht auf die privaten Felder der Basisklasse zugreifen
            // Wir koennen sie aber "protected" machen, um darauf zugreifen zu koennen
            Console.WriteLine($"{_name} is flying with a wing span of {WingSpanInCm} cm!");
        }

        // Weil Talk() virtual ist, koennen wir die Methode mit "override" ueberschreiben
        public override void Talk()
        {
            Console.WriteLine("Chirp chirp!");

            // Wir koennen keine "abstrakte" Methode einer abstrakten Basisklasse aufrufen
            //base.Talk(); 
        }
    }
}
