using QuizGame.Models;
using System.Text.Json;

namespace QuizGame
{
    public class Program
    {
        private const string HighScoreFilePath = "highscore.json";
        private static readonly string QuestionFilePath = Path.Combine("Data", "questions.json");

        // Highlander Prinzip: Es kann nur eine Main-Methode (fuer den Einstieg) geben
        static void Main(string[] args)
        {
            var highscore = new HighScore(ReadJsonFile<User>(HighScoreFilePath));

            var currentUser = new User
            {
                Name = GetUserName()
            };

            currentUser.ShowGreeting();

            QuizItem[] quizItems = ReadJsonFile<QuizItem>(QuestionFilePath);

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
                    currentUser.IncrementScore();
                }
            }

            currentUser.ShowScore();

            highscore.Add(currentUser);
            highscore.Show();
            WriteJsonFile(HighScoreFilePath, highscore.Entries);

            Console.WriteLine("Beliebige Taste zum Beenden druecken...");
            Console.ReadKey();
        }

        private static string GetUserName()
        {
            Console.WriteLine("Wie lautet dein Name?");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "Gast";
            }

            return name;
        }

        private static T[] ReadJsonFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<T[]>(json);
                if (result != null)
                {
                    return result;
                }
            }

            // default gibt den Standartwert des Object-Typs zurueck
            // int = 0, float = 0, bool = false, object = null (arrays, strings usw.)
            //return default;

            // Besser ist es aber ein leeres Array zurueck zu geben
            return [];
        }

        private static void WriteJsonFile(string filePath, List<User> entries)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(entries, options);
            File.WriteAllText(filePath, json);
        }
    }
}
