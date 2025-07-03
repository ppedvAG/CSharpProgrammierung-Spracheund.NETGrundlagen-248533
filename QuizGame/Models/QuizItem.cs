using QuizGame.Enums;
using System.Diagnostics;

namespace QuizGame.Models
{
    // Im Debug-Modus wird im Tooltyp der Inhalt der Instanz angezeigt statt dem Typen
    // Frueher hat man ToString() ueberladen, aber das ist "Bad Practice", weil es Auswirkung auf das Release hat
    [DebuggerDisplay("{Question} [{Difficulty}] {ExpectedAnswer}")]
    public class QuizItem
    {
        #region Properties

        public string Question { get; set; }

        // NullReferenceException verhindern, indem wir das Array leer initialisieren
        public string[] Options { get; set; } = [];

        public string ExpectedAnswer { get; set; }

        public Difficulty Difficulty { get; set; }

        public string Hint { get; set; }

        #endregion

        public int AskQuestion()
        {
            PrintQuestion();

            return ReadAnswer();
        }

        private void PrintQuestion()
        {
            // Leerzeile hinzufuegen
            Console.WriteLine();
            Console.WriteLine(Question);
            Console.WriteLine($"\t(0)\tfür einen Hinweis (Punktabzug)\n");

            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"\t({i + 1})\t{Options[i]}");
            }
        }

        private int ReadAnswer()
        {
            string? input = Console.ReadLine();

            // Werte konvertieren bzw. parsen
            if (int.TryParse(input, out int number))
            {
                // Potentielle IndexOutOfRangeException: Wir muessen pruefen, ob der index innerhalb des Wertebereiches liegt
                int index = number - 1;
                if (index >= 0 && index < Options.Length)
                {
                    string answer = Options[index];
                    if (answer.Equals(ExpectedAnswer, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("Richtig!");
                        return GetPoints();
                    }

                    index = Options.ToList().IndexOf(ExpectedAnswer) + 1;
                    Console.WriteLine($"Leider falsch. Richtige Antwort: ({index}).");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Hinweis: " + Hint);
                    return ReadAnswer() / 2;
                }
            }

            Console.WriteLine("Ungültige Eingabe! Nochmal versuchen:");
            return ReadAnswer();
        }

        private int GetPoints() => Difficulty switch
        {
            Difficulty.Easy => 2,
            Difficulty.Medium => 4,
            Difficulty.Hard => 8,
            _ => 0,
        };
    }
}
