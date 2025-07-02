using OOP_Poly.Models;

namespace OOP_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Geht nicht, da die Basisklasse abstrakt ist
            //var bunny = new CreatureBase("Bunny", 3);

            RunApplication();

            Console.WriteLine("\n10 Zufaellige Kreaturen erzeugen und Typen zaehlen:");
            CreatureBase[] arrayOfCreatures = [
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
                CreateRandomCreature(),
            ];

            var humanCount = CountCreatureType(typeof(Human), arrayOfCreatures);
            var birdCount = CountCreatureType(typeof(Bird), arrayOfCreatures);
            var bunnyCount = CountCreatureType(typeof(Bunny), arrayOfCreatures);

            Console.WriteLine($"Es wurden {humanCount} 🥱 erzeugt.");
            Console.WriteLine($"Es wurden {birdCount} 🦜 erzeugt.");
            Console.WriteLine($"Es wurden {bunnyCount} 🐰 erzeugt.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static int CountCreatureType(Type targetType, CreatureBase[] arrayOfCreatures)
        {
            int count = 0;

            foreach (var creature in arrayOfCreatures)
            {
                Type creatureType = creature.GetType();
                if (creatureType == targetType)
                {
                    count++;
                }

                //Console.WriteLine($"{creatureType.Name}: {creature.GetName()}");
            }

            return count;
        }

        private static void RunApplication()
        {
            Console.WriteLine("Waehlen Sie eine Art von Kreatur:");
            Console.WriteLine("1: Human\n2: Bird\n3: Bunny");

            var input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                // Polymorphismus: CreatureBase kann zur Laufzeit ein Mensch, Vogel oder Kaninchen sein
                CreatureBase? creature = CreateCreatureInstance(number);

                if (creature != null)
                {
                    // Jede Kreatur kann Laute von sich geben!
                    creature.Talk();

                    // Pruefe, ob die Kreatur ein Mensch ist und lasse sie arbeiten
                    CheckForHumanCreatureToDoSomeWork(creature);
                }

            }

            Console.WriteLine("\nProgramm wiederholen? (j/n)");
            var answer = Console.ReadLine();
            if (answer == "j" || answer == "J")
            {
                // Rekursion: Methode ruft sich selbst wieder auf
                // (Alternative zur Endlosschliefe mit break)
                RunApplication();
            }
        }

        // Mit ? hinter dem Typen kennzeichnen wir explizit, dass das Objekt null sein kann (Nullable)
        private static CreatureBase? CreateCreatureInstance(int selection)
        {
            switch (selection)
            {
                case 1:
                    return new Human("Hans", "Entwickler");
                case 2:
                    return new Bird("Tweety", 2);
                case 3:
                    return new Bunny("Bugs Bunny");
                default:
                    return null;
            }
        }

        private static CreatureBase CreateRandomCreature()
        {
            // Zufallszahl zwischen 1 und 3
            int type = Random.Shared.Next(1, 4);
            var result = CreateCreatureInstance(type);
            if (result == null)
            {
                return CreateRandomCreature();
            }

            return result;
        }

        private static void CheckForHumanCreatureToDoSomeWork(CreatureBase creature)
        {
            // Loesung: Wir muessen pruefen ob die Kreatur ein Mensch ist
            // Variante 1: Mit GetType() zur Laufzeit pruefen (aelteste Methode)
            var runtimeType = creature.GetType();
            if (runtimeType == typeof(Human))
            {
                // Wir sagen dem Compiler an dieser Stelle, dass die Kreatur ein Mensch ist, indem wir das Object als Human casten
                var human = (Human)creature;
                human.GoToWork();
            }

            // Variante 2 der Ueberpruefung mit 'as' als cast
            {
                // Es wird versucht die Creature als Mensch zu casten. Wenn es fehlschlaegt, wird das null zurueckgegeben
                var human = creature as Human;
                if (human != null)
                {
                    human.GoToWork();
                }
            }

            // Variante 3 der Ueberpruefung mit 'is' als cast (neueste Variante)
            {
                // Es wird versucht die Creature als Mensch zu casten. Wenn es fehlschlaegt, wird das false zurueckgegeben
                if (creature is Human human)
                {
                    human.GoToWork();
                }
            }
        }
    }
}
