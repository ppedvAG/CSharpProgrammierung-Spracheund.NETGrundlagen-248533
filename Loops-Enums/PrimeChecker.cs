public class PrimeChecker
{
    internal static void _Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bitte eine Priminput eingeben: ");
            int input = int.Parse(Console.ReadLine());

            bool isPrime = false;

            if (input <= 1)
            {
                isPrime = false;
            }
            else if (input == 2)
            {
                isPrime = true;
            }
            else if (input % 2 == 0) // Ist es eine gerade Zahl
            {
                isPrime = false;
            }
            else
            {
                for (int i = 3; i < input; i += 2) // i = i + 2
                {
                    if (input % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"Glückwunsch! {input} ist eine Primzahl.");
            }
            else
            {
                Console.WriteLine($"{input} ist leider keine Primzahl.");
            }


            Console.WriteLine("Weitere Primzahl pruefen? (j/N)");

            if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}
