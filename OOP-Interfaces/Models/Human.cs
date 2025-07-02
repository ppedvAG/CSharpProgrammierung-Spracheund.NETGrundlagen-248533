// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
using OOP_Interfaces.Contracts;

namespace OOP.Models
{
    // Die Klasse Human erbt von der Basisklasse Creature und implementiert die Schnittstelle IWorker
    // Man sagt nicht, dass eine Klasse von einem Interface erbt, sondern dass es das Interface implementiert
    public class Human : Creature, IWorker
    {
        public string Job { get; set; }

        public Human(string name, string job) 
            : base(name, 0)
        {
            Job = job;
        }

        public void GoToWork()
        {
            Console.WriteLine($"{_name} is going to work as a {Job}.");
        }
    }
}
