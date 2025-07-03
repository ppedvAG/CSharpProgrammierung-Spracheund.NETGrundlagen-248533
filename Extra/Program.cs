namespace Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension Methods");

            Console.WriteLine("Quersumme von 4711");
            Console.WriteLine("Iterativ:\t" + MathExtensions.QuersummeIterativ(4711));

            // Als Extension Method
            Console.WriteLine("Iterativ:\t" + 4711.QuersummeIterativ());
            Console.WriteLine("Rekursiv:\t" + 4711.QuersummeRekursiv());



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    // Extension Klassen muessen als static deklariert werden
    public static class MathExtensions
    {
        // Der erste Parameter von Extension Methoden benutzt das this Keyword
        // Implementierung iterativ, weil sie eine Schleife benutzt
        public static int QuersummeIterativ(this int zahl)
        {
            int summe = 0;
            while (zahl > 0)
            {
                // Restwert der Division addieren
                summe += zahl % 10;
                // Um 10er Potenz verkleinern
                zahl /= 10;
            }
            return summe;
        }

        public static int QuersummeRekursiv(this int zahl)
        {
            if (zahl < 10)
            {
                return zahl;
            }

            var rest = zahl % 10;
            return rest + QuersummeRekursiv(zahl / 10);
        }
    }
}
