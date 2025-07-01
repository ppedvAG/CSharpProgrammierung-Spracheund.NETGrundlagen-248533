// Mit using koennen wir den Namespace einbinden
using OOP.PetStore; // In diesem Namespace ist Creature enthalten, was wir benutzen wollen

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Syntax um sich ein Objekt-Instanz zu erzeugen
            Creature unknown = new Creature(); // Creature mit Default-Konstruktor erzeugen
            Creature dog = new Creature("Bello", 5);
            Creature cat = new Creature("Garfield", 3);

            cat.FavoriteFood = "Lasagne";
            cat.FavoriteDrink = "Milch";

            dog.Talk();
            cat.Talk();
            cat.CelebrateBirthday();

            // Statische Methoden werden so aufgerufen
            Creature.ShowNumberOfCreatures();


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

}
