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

            Console.WriteLine("Was ist die Hauptstadt von Deutschland?");
            string? antwort = Console.ReadLine();
            if (antwort == "Berlin")
            {
                // Punktzahl um 1 erhoehen
                score++;
            }

            Console.WriteLine("Wie viele Beine hat eine Spinne?");
            antwort = Console.ReadLine();
            if (antwort == "8")
            {
                score++;
            }


            Console.WriteLine($"Du hast {score} Punkte erreicht.");



            Console.WriteLine("Beliebige Taste zum Beenden druecken...");
            Console.ReadKey();
        }
    }
}
