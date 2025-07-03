
namespace QuizGame.Models
{
    public class HighScore
    {
        // Hier verwenden wir eine Liste, um die Einträge erweitern zu können
        public List<User> Entries { get; }

        public HighScore(User[] users)
        {
            Entries = users.ToList();
        }

        internal void Add(User currentUser)
        {
            Entries.Add(currentUser);
        }

        internal void Show()
        {
            Console.WriteLine("\n  H I G H S C O R E\n= = = = = = = = = = =");

            var scores = Entries.OrderByDescending(x => x.Score).Take(10).ToArray();
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {scores[i].Name}\t{scores[i].Score}");
            }
        }
    }
}
