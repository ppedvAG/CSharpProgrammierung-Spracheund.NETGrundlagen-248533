using QuizGame.Models;
using System.Text.Json;

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

            QuizItem[] quizItems = ReadJsonFile<QuizItem>(Path.Combine("Data", "questions.json"));

            // Zu Testzwecken verwenden wir nur die ersten 3 Fragen
            // Precompiler Anweisung: Wenn wir uns im DEBUG Modus befinden
#if DEBUG
            quizItems = quizItems.Take(3).ToArray();
#endif

            foreach (QuizItem item in quizItems)
            {
                bool correct = item.AskQuestion();
                if (correct)
                {
                    score++;
                }
            }

            Console.WriteLine($"Du hast {score} Punkte erreicht.");

            Console.WriteLine("Beliebige Taste zum Beenden druecken...");
            Console.ReadKey();
        }

        private static T[] ReadJsonFile<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<T[]>(json);
            if (result != null)
            {
                return result;
            }

            // default gibt den Standartwert des Object-Typs zurueck
            // int = 0, float = 0, bool = false, object = null (arrays, strings usw.)
            //return default;

            // Besser ist es aber ein leeres Array zurueck zu geben
            return [];
        }
    }
}
