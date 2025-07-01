// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
namespace OOP_Poly.Models
{
    public class Bunny : CreatureBase
    {
        public Bunny(string name) : base(name, 0) { }

        public void Hop() => Console.WriteLine($"{_name} is hopping!");

        public override void Talk()
        {
            Console.Beep();
            Console.Beep();
            Console.WriteLine("Beep beep!");
        }
    }
}
