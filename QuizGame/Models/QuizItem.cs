namespace QuizGame.Models
{
    public class QuizItem
    {
        #region Properties

        public string Question { get; set; }

        // NullReferenceException verhindern, indem wir das Array leer initialisieren
        public string[] Options { get; set; } = [];

        public string ExpectedAnswer { get; set; }

        #endregion

        public bool AskQuestion()
        {
            // Leerzeile hinzufuegen
            Console.WriteLine();
            Console.WriteLine(Question);

            // Mehrere Antworten moeglich
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"\t({i + 1})\t{Options[i]}");
            }

            string? input = Console.ReadLine();

            // Werte konvertieren bzw. parsen
            if (int.TryParse(input, out int number))
            {
                // Potentielle IndexOutOfRangeException: Wir muessen pruefen, ob der index innerhalb des Wertebereiches liegt
                int index = number - 1;
                if (index >= 0 && index < Options.Length)
                {
                    string antwort = Options[index];

                    // Es kann eine NullReferenceException auftreten, weswegen wir einen Null-Check durchfuehren
                    // Equals von der Klasse string hat Ueberladungen, die nuetzlich sind
                    // InvariantCulture: Unabhaengigkeit von der eingestellten Sprache des Betriebsystems
                    // IgnoreCase: Groß- und Kleinschreibung wird ignoriert
                    if (antwort is not null && antwort.Equals(ExpectedAnswer, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("Richtig!");
                        return true;
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

            return false;
        }
    }
}
