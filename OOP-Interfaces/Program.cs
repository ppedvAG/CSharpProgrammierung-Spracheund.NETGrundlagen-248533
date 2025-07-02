
using OOP.Models;
using OOP_Interfaces.Contracts;

namespace OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beispiel Arbeitsvermittlung: Uns ist voellig egal, wer die Arbeit verrichtet.
            // Wichtig ist nur, dass wir ein Objekt haben, was die Arbeit verrichtet kann. (Interface als Contract)
            // Interfaces sind eine sehr wichtiges Konzept der Abstraktion. (Entkopplung und Polymorphismus)
            IWorker worker = CreateWorker("Entwickler");
            Console.WriteLine("Was bin ich?\t" + worker.GetType().Name);
            worker.GoToWork();

            Console.WriteLine("\nWas kann unsere Objekt-Instanz?");
            CheckRuntimeAbilities(worker);

            var drone = new Drone();
            CheckRuntimeAbilities(drone);
            drone.GoToWork();
            drone.Fly();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        private static void CheckRuntimeAbilities(object obj)
        {
            // Was wir sehen ist, dass z. B. Max zur Laufzeit ein Mensch bleibt.
            // ABER: Zur Compilerzeit kann er "polymorph" sein, d. h. verschiedene Typen annehmen: Creature, ILifeform, IWorker, Human sein.

            var currentType = obj.GetType();
            Console.WriteLine("Is Creature?\t" + (currentType == typeof(Creature)));
            Console.WriteLine("Is Human?\t" + (currentType == typeof(Human)));
            Console.WriteLine("Is Robot?\t" + (currentType == typeof(Robot)));
            Console.WriteLine("Is Bird?\t" + (currentType == typeof(Bird)));
            Console.WriteLine("Can Fly?\t" + (currentType == typeof(IFlyable)));
            Console.WriteLine("Can Work?\t" + (currentType == typeof(IWorker)));
            Console.WriteLine("Is Lifeform?\t" + (currentType == typeof(ILifeform)));
        }

        private static IWorker CreateWorker(string searchTerm)
        {
            // Wenn es eine gerade Zahl ist, erzeuge einen Menschen
            if (Random.Shared.Next(1, 3) % 2 == 0)
            {
                return new Human("Max", searchTerm);
            } 
            else
            {
                return new Robot(searchTerm);
            }
        }
    }
}
