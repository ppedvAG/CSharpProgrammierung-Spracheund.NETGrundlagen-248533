internal class Program
{
    // Enums muessen ausserhalb von Methoden (hier Main()) deklariert werden
    // Enums sind eigene Datentypen, die eine beliebige Aufzaehlung von Konstanten darstellen
    enum Weather 
    { 
        Sunny = 1,
        Rainy = 2,
        Cloudy = 4,
        Windy = 8
    };

    private static void Main(string[] args)
    {
        #region Loops

        // Kopfgesteuerte Schleife

        int start = 0, end = 10, index = start;
        while (index < end)
        {
            Console.WriteLine(index);
            index++; // index + 1;
        }

        // Endlosschleife
        while (true)
        {
            // Alle Statements innerhalb von geschweiften Klammern { } nennt man auch Block
            {
                index++;
            }

            if (index == 15)
            {
                continue; // Springe zum Start der Schleife
            }

            Console.WriteLine(index);

            if (index > 20)
            {
                // Bei break ueberspringt das Programm den sog. Block, d. h. die while-Schleife
                break;
            }
        }

        // Beispiel fuer fussgesteuerte Schleife
        ConsoleKey endLoopKey;
        do
        {
            Console.WriteLine("Leertaste druecken um Programm fortzusetzen");
            endLoopKey = Console.ReadKey().Key;
        }
        while (endLoopKey != ConsoleKey.Spacebar);
        Console.WriteLine("Programm fortgesetzt");


        var numbers = new int[] { 34, 39, 9 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index: {i}, Value: {numbers[i]}");
        }
        Console.WriteLine();

        var names = new string[] { "Andi", "Bibi", "Caro" };
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        #endregion

        #region Durch Enums iterieren

        foreach (var current in Enum.GetValues(typeof(Weather)))
        {
            Console.WriteLine($"#{(int)current} ist {current}!");
        }

        Console.WriteLine("Durch Wochentage iterieren");
        foreach (var current in Enum.GetValues(typeof(DayOfWeek)))
        {
            Console.WriteLine($"#{(int)current} ist {current}!");
        }

        #endregion

        #region Switch

        var someWeather = Weather.Cloudy;

        switch (someWeather)
        {
            case Weather.Sunny:
                Console.WriteLine("Es ist sonnig");
                break; // break; ist notwendig, sonst wuerden die nachfolgenden Statements auch ausgefuehrt werden

            case Weather.Rainy:
                Console.WriteLine("Heute bleibe ich zu Hause");
                break;

            case Weather.Cloudy:
                Console.WriteLine("Angenehm und gehe raus");
                break;

            case Weather.Windy:
                Console.WriteLine("Es ist windig");
                break;

            default:
                Console.WriteLine("Unbekannt (entspricht dem else-Block)");
                break;
        }

        #endregion


        Console.WriteLine("Press any key");
        Console.ReadKey();
    }
}