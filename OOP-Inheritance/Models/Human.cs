// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
namespace OOP.Models
{
    public class Human : Creature
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
