using OOP.Models;

namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tweety = new Bird("Tweety", 20);
            tweety.Talk();
            tweety.Fly();

            Console.WriteLine(tweety.ToString());
            Console.WriteLine(tweety); // Das selbe wie oben, nur wird ToString() automatisch aufgerufen

            Console.WriteLine("\nEntwickler Tim erzeugen und Geburtstag feiern.");
            var developer = new Human("Tim", "Developer");
            developer.CelebrateBirthday();
            developer.GoToWork();
            Console.WriteLine(developer);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
