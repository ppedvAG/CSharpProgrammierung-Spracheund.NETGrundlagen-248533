namespace QuizGame.Models
{
    public class User
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public void IncrementScore()
        {
            Score++;
        }

        public void ShowGreeting()
        {

            Console.WriteLine($"Hallo, {Name}!");
        }

        public void ShowScore()
        {
            Console.WriteLine($"Du hast {Score} Punkte erreicht.");
        }
    }
}
