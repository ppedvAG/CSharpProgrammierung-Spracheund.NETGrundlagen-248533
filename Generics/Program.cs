using OOP_Poly.Models;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wenn es keine Generics gaebe...
            var listOfDateTimes = new ListWithoutGenerics();
            listOfDateTimes.Add(DateTime.Now);

            object? lastDate = listOfDateTimes.Get(0);
            if (lastDate is DateTime lastDateTime)
            {
                Console.WriteLine(lastDateTime);
            }

            // Die Idee hinter Generics ist, dass wir nicht mit der Basisklasse object arbeiten muessen
            // (welche die Basisklasse fuer jedes Objekt ist). Wir koennen gleich mit dem "richtigen" Typ arbeiten.
            // Wir muessen fuer die Verwendung keine Casts machen, d. h. und damit Laufzeitfehler vermeiden.
            // Der Compiler kann uns schon vorher mitteilen, ob der verwendete Typ nicht passt.
            var creatures = new List<CreatureBase>(10);
            creatures.Add(new Bunny("Bugs"));
            creatures.Add(new Bird("Tweety", 20));

            // Eine generische Liste existiert nur zur Entwurfszeit
            // Der Compiler wurede jede Variante der Liste in Code umwandeln
            // List<int> --> ListOfInt32
            // List<CreatureBase> --> ListOfCreatureBase
            // Wir sparen uns sehr viel Code-Duplikation damit

            List<int> listOfNumbers = [78, 45, 12, 99, 27, 42, 63, 91, 74, 36];
            var secondListOfNumbers = listOfNumbers[1];

            Console.WriteLine("\nExistiert 42 in der Liste?");
            Console.WriteLine(listOfNumbers.Contains(42));

            // Find verwendet ein sog. Predicate; eine Lambda-Expression, welche die Logik fuer die Bedingung enthaelt
            Console.WriteLine(listOfNumbers.Find(x => x == 42));

            Console.WriteLine("\nFind die erste Zahl kleiner als 42");
            Console.WriteLine(listOfNumbers.Find(x => x < 42)); // Gibt 12 zurueck

            Console.WriteLine("\nListe sortieren");
            listOfNumbers.Sort(); // VORSICHT: Die originale Liste wird geaendert
            foreach (var number in listOfNumbers)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine("\n");

            // Alternative mit Linq
            Console.WriteLine("\nListe sortieren mit Linq");
            // OrderBy benoetigt ebenfalls ein Predicate
            foreach (var number in listOfNumbers.OrderBy(x => x))
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine("\n");

            // Das Predicate hat den Vorteil, dass wir auch auf Eigenschaften zugreifen koennen
            foreach (var creature in creatures.OrderBy(x => x.Age))
            {
                Console.WriteLine(creature);
            }
            Console.WriteLine("\n");


            // Im Gegensatz zu einer Liste enthaelt das Dictionary sog. Key-Value-Paare
            Dictionary<DayOfWeek, string> menuOfTheWeek = new Dictionary<DayOfWeek, string>();
            menuOfTheWeek.Add(DayOfWeek.Monday, "Pizza");
            menuOfTheWeek.Add(DayOfWeek.Tuesday, "Burger");
            menuOfTheWeek.Add(DayOfWeek.Wednesday, "Nudeln");
            menuOfTheWeek.Add(DayOfWeek.Thursday, "Pfannkuchen");
            menuOfTheWeek.Add(DayOfWeek.Friday, "Pfannkuchen");
            menuOfTheWeek.Add(DayOfWeek.Saturday, "Pfannkuchen");
            menuOfTheWeek.Add(DayOfWeek.Sunday, "Pfannkuchen");

            Console.WriteLine("Was gibt es heute im Menu?");
            var today = DateTime.Now.DayOfWeek;
            Console.WriteLine($"\t{menuOfTheWeek[today]}");

            Console.WriteLine("\nUeber alles iterieren");
            // Ueber Dictionary iterieren
            foreach (KeyValuePair<DayOfWeek, string> entry in menuOfTheWeek)
            {
                // Key ist vom Typ DayOfWeek, Value ist vom Typ string
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // Beispiel einer Liste ohne Generics; eher unbrauchbar
        public class ListWithoutGenerics
        {
            public object[] Items { get; } = new object[10];

            public void Add(object item)
            {
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i] == null)
                    {
                        Items[i] = item;
                        return;
                    }
                }
            }

            public object Get(int index)
            {
                return Items[index];
            }
        }
    }
}
