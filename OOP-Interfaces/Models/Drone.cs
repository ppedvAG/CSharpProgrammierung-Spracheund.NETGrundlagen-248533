// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
using OOP_Interfaces.Contracts;

namespace OOP.Models
{
    public class Drone : Robot, IFlyable
    {
        public Drone()
            : base("Delivery Drone")
        {            
        }

        public void Fly()
        {
            Console.WriteLine($"Drone {Id} is delivering a package.");
        }
    }
}
