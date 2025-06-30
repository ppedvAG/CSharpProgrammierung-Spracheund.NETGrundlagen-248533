internal class Program
{
    enum CalcOperation { Addition = 1, Subtraktion, Multiplikation, Division }

    static void Main(string[] args)
    {
        while (true)
        {
            double n1 = GetInput("Gib eine Zahl ein: ");
            double n2 = GetInput("Gib eine weitere Zahl ein: ");

            foreach (CalcOperation op in Enum.GetValues<CalcOperation>())
            {
                Console.WriteLine($"{(int)op}: {op}");
            }

            var operation = GetCalcOperation();
            var ergebnis = Calculate(n1, n2, operation);
            var symbol = CalcOperationToSymbol(operation);
            Console.WriteLine($"{n1} {symbol} {n2} = {ergebnis}");

            Console.WriteLine("Wiederholen? (Enter)");
            if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                break;
        }
    }

    static double GetInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            double n;
            bool success = double.TryParse(input, out n);
            if (success)
                return n;
        }
    }

    static CalcOperation GetCalcOperation()
    {
        CalcOperation[] values = Enum.GetValues<CalcOperation>();
        while (true)
        {
            string input = Console.ReadLine();
            CalcOperation operation;
            bool success = Enum.TryParse(input, out operation);
            if (!values.Contains(operation))
            {
                Console.WriteLine("Keine gültige Rechenoperation ausgewählt");
                continue;
            }
            if (success)
                return operation;
        }
    }

    static double Calculate(double x, double y, CalcOperation op)
    {
        switch (op)
        {
            case CalcOperation.Addition:
                return x + y;
            case CalcOperation.Subtraktion:
                return x - y;
            case CalcOperation.Multiplikation:
                return x * y;
            case CalcOperation.Division:
                return y != 0 ? x / y : double.NaN;
            default:
                return double.NaN;
        }
    }

    static string CalcOperationToSymbol(CalcOperation op)
    {
        switch (op)
        {
            case CalcOperation.Addition:
                return "+";
            case CalcOperation.Subtraktion:
                return "-";
            case CalcOperation.Multiplikation:
                return "*";
            case CalcOperation.Division:
                return "/";
            default:
                return "";
        }
    }
}