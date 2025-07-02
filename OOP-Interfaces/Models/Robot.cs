// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
using OOP_Interfaces.Contracts;

namespace OOP.Models
{
    public class Robot : IWorker
    {
        public string Id { get; }

        public string Job { get; set; }

        public Robot(string job)
        {
            // Die ersten 5 Zeichen einer Guid verwenden
            // Guids sind eine zufaellige Abfolge von Hex-Zahlen nach einem spezifischen Muster
            Id = Guid.NewGuid().ToString().Substring(0, 5);
            Job = job;
        }

        public void GoToWork()
        {
            Console.WriteLine($"Robot {Id} is going to work as a {Job}.");
        }
    }
}
