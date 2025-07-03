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

            AskQuestion("Was ist die Hauptstadt von Deutschland?", "Berlin", "Wien", "Frankfurt", "Muenchen", "Berlin");
            AskQuestion("Wie viele Beine hat eine Spinne?", "8", "6", "8", "4", "12");

            Console.WriteLine($"Du hast {score} Punkte erreicht.");

            Console.WriteLine("Beliebige Taste zum Beenden druecken...");
            Console.ReadKey();
        }

        // Multiple Choice: Wir fuegen die Antwortmoeglichkeiten als Parameter hinzu von 0 bis n
        private static void AskQuestion(string question, string expected, params string[] options)
        {
            // Leerzeile hinzufuegen
            Console.WriteLine();
            Console.WriteLine(question);

            // Mehrere Antworten moeglich
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"\t({i + 1})\t{options[i]}");
            }

            string? input = Console.ReadLine();

            // Werte konvertieren bzw. parsen
            if (int.TryParse(input, out int number))
            {
                // Potentielle IndexOutOfRangeException: Wir muessen pruefen, ob der index innerhalb des Wertebereiches liegt
                int index = number - 1;
                if (index >= 0 && index < options.Length)
                {
                    string antwort = options[index];

                    // Es kann eine NullReferenceException auftreten, weswegen wir einen Null-Check durchfuehren
                    // Equals von der Klasse string hat Ueberladungen, die nuetzlich sind
                    // InvariantCulture: Unabhaengigkeit von der eingestellten Sprache des Betriebsystems
                    // IgnoreCase: Groß- und Kleinschreibung wird ignoriert
                    if (antwort is not null && antwort.Equals(expected, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("Richtig!");
                        // Punktzahl um 1 erhoehen
                        score++;

                        // Funktion hier verlassen ohne Rueckgabe, weil void
                        return;
                    }

                    Console.WriteLine("Leider falsch.");
                }
                else
                {
                    Console.WriteLine("Diese Option steht nicht zur Verfügung!");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
        }
    }
}
