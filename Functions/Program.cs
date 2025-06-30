internal class Program
{
    private static void Main(string[] args)
    {
        int a = 3, b = 4;

        // Ganzzahlen addieren
        int result = AddNumbers(a, b);
        result = AddNumbers(a, b, -3);
        Console.WriteLine($"Addition der Integers: {result}");

        // Gleitkommazahlen addieren
        var result2 = AddNumbers(1f, .78, 1e-6);
        Console.WriteLine($"\nAddition der Gleitkommazahlen: {result2}");

        // Beliebige Anzahl von Werten addieren
        var result3a = SumNumbers(1, 2, 3, 4, 5); // weil wir das Keyword "params" verwenden, muessen wir kein neues Array erzeugen
        var result3b = SumNumbers(new double[] { 6, 7, 8, 9, 10 });
        Console.WriteLine($"\nAddition der beliebigen Anzahl von Werten: {result3a}");

        // Durch 0 teilen
        string error;
        var result4 = Divide(1, 0, out error);

        if (error != "")
        {
            Console.WriteLine($"\n{error}");
        } 
        else
        {
            Console.WriteLine($"\nDivision: {result4}");
        }

        Console.WriteLine("Alternativer Aufruf mit Tuples");
        var (result5, error2) = DivideWithTuples(1, 0);
        if (error2 != "")
        {
            Console.WriteLine($"\n{error2}");
        }
        else
        {
            Console.WriteLine($"\nDivision: {result5}");
        }

        Console.WriteLine("Bitte Zahl eingeben: ");
        var input = Console.ReadLine();

        // Wenn ein Buchstabe eingegeben wird, tritt eine System.FormatException auf
        //var number = int.Parse(input);

        bool success = int.TryParse(input, out int number);
        if (success)
        {
            Console.WriteLine($"Die eingegebene Zahl ist: {number}");
        }
        else
        {
            Console.WriteLine("Die eingegebene Zahl ist ungültig");
        }
    }

    private static int AddNumbers(int a, int b, int c = 0)
    {
        var result = a + b + c;
        return result;
    }

    // Methoden können überladen werden durch Anzahl und Typ der Parameter
    private static double AddNumbers(double a, double b, double c)
    {
        var result = a + b + c;
        return result;
    }

    private static double SumNumbers(params double[] numbers)
    {
        double result = 0;
        foreach (var number in numbers) 
        {
            // Kurzform für result = result + number
            result += number; 
        }

        return result;
    }

    private static double Divide(double a, double b, out string error)
    {
        if (b == 0)
        {
            error = "Division durch 0 ist nicht möglich";
            return 0;
        }

        error = "";
        return a / b;
    }

    // Seit neueren C# Versionen sind Tuples erlaubt
    private static (double result, string error) DivideWithTuples(double a, double b)
    {
        if (b == 0)
        {
            return (0, "Division durch 0 ist nicht möglich");
        }

        return (a / b, "");
    }
}