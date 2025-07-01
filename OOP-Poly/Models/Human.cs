// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
namespace OOP_Poly.Models
{
    // Jede abgeleitete Klasse muss die abstrakten Mitglieder implementieren!
    public class Human : CreatureBase
    {
        public string Job { get; set; }

        public Human(string name, string job) 
            : base(name, 42)
        {
            Job = job;
        }

        public void GoToWork()
        {
            Console.WriteLine($"{_name} is going to work as a {Job}.");
        }

        public override void Talk()
        {
            Console.WriteLine($"Hello my name is {_name} and I am {Age} years old.");
        }
    }
}
