using QuizGame.Models;

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

            QuizItem[] quizItems = [
                new QuizItem
                {
                    Question = "Was ist die Hauptstadt von Deutschland?",
                    ExpectedAnswer = "Berlin",
                    Options = ["Wien", "Frankfurt", "Muenchen", "Berlin"]
                },
                new QuizItem 
                {
                    Question = "Wie viele Beine hat eine Spinne?",
                    ExpectedAnswer = "8",
                    Options = ["6", "8", "4", "12"]
                }
            ];

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
    }
}
