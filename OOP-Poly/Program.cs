using OOP_Poly.Models;

namespace OOP_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geht nicht, da die Basisklasse abstrakt ist
            //var bunny = new CreatureBase("Bunny", 3); 

            RunApplication();

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
