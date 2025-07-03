namespace QuizGame
{
    public class Program
    {
        static int score = 0;

        // Highlander Prinzip: Es kann nur eine Main-Methode (fuer den Einstieg) geben
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lautet dein Name?");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "Gast";
            }

            Console.WriteLine($"Hallo, {name}!");

            AskQuestion("Was ist die Hauptstadt von Deutschland?", "Berlin");
            AskQuestion("Wie viele Beine hat eine Spinne?", "8");

            Console.WriteLine($"Du hast {score} Punkte erreicht.");



            Console.WriteLine("Beliebige Taste zum Beenden druecken...");
            Console.ReadKey();
        }

        private static string? AskQuestion(string question, string expected)
        {
            Console.WriteLine(question);
            string? antwort = Console.ReadLine();
            // Es kann eine NullReferenceException auftreten, weswegen wir einen Null-Check durchfuehren
            // Equals von der Klasse string hat Ueberladungen, die nuetzlich sind
            // InvariantCulture: Unabhaengigkeit von der eingestellten Sprache des Betriebsystems
            // IgnoreCase: Groß- und Kleinschreibung wird ignoriert
            if (antwort is not null && antwort.Equals(expected, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Richtig!");
                // Punktzahl um 1 erhoehen
                score++;
            }
            else
            {
                Console.WriteLine("Leider falsch.");
            }

            return antwort;
        }
    }
}
