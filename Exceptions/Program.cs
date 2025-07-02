namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = ReadNumberFromConsole();

            Console.WriteLine("Die eingegebene Zahl ist: {0}", number);

            Console.WriteLine("Taste drücken um das Programm zu beenden");
            Console.ReadKey();
        }

        private static float ReadNumberFromConsole()
        {
            // Fragezeichen am Ende macht den Typen nullable
            float? number = null;

            do
            {
                try
                {
                    // checked prueft explizit auf overflow
                    // Wenn die Zahl zu gross ist, faengt sie wieder bei 0 an bzw. dem negativen Maxi4mum
                    checked
                    {

                        Console.WriteLine("Bitte eine Zahl eingeben:\t");
                        var input = Console.ReadLine();

                        number = float.Parse(input.ToString());

                        CheckForUnluckyNumber(number); 
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Bitte eine numerische Zahl eingeben.\n");
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Die eingegebene Zahl ist zu groß.\n");
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Ungültige Eingabe.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unbekannter Fehler ist aufgetreten.\n" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Ende der Eingabe");
                }
            } while (number == null);

            return number.Value;
        }

        private static void CheckForUnluckyNumber(float? number)
        {
            // number.HasValue ist gleichbedeutend mit number != null
            if (number.HasValue && number % 13 == 0)
            {
                throw new UnluckyNumberException(number.Value);
            }
        }
    }

    // Jede Exception muss von der Basisklasse Exception abgeleitet werden
    public class UnluckyNumberException : Exception
    {
        public UnluckyNumberException(double number) 
            : base($"Die Zahl {number} bring unglück.") { }
    }
}
