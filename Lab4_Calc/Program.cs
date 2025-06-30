internal class Program
{
    //Enum-Definition
    enum CalcOperation { Addition = 1, Subtraktion, Multiplikation, Division }

    private static void Main(string[] args)
    {
        //Schleife für Programm-Wiederholung
        do
        {
            //Eingabe und Parsing der ersten Zahl
            Console.Write("\nGib eine Zahl ein: ");
            double n1 = double.Parse(Console.ReadLine());

            //Eingabe und Parsing der zweiten Zahl
            Console.Write("Gib eine weitere Zahl ein: ");
            double n2 = double.Parse(Console.ReadLine());

            //Anzeige der möglichen Rechenoperationen
            Console.WriteLine("\nWähle eine Rechenoperation:");
            var values = Enum.GetValues(typeof(CalcOperation));
            for (int i = 1; i <= values.Length; i++)
            {
                Console.WriteLine($"{i}: {(CalcOperation)i}");
            }
            //Abfrage der Benutzereingabe
            Console.Write("Auswahl: ");
            CalcOperation op = (CalcOperation)int.Parse(Console.ReadLine());

            //Deklaration und Initialisierung der Ergebnisvariablen
            double result = 0d;

            //Switch zur Auswahl der Rechenoperation
            switch (op)
            {
                //Berechnung des Ergebnisses
                case CalcOperation.Addition:
                    result = n1 + n2;
                    break;
                case CalcOperation.Subtraktion:
                    result = n1 - n2;
                    break;
                case CalcOperation.Multiplikation:
                    result = n1 * n2;
                    break;
                case CalcOperation.Division:
                    //Prüfung einer möglichen Teilung durch null
                    if (n2 == 0)
                    {
                        Console.WriteLine("\nEine Division durch 0 ist nicht erlaubt.");
                        Console.WriteLine("Wiederholen? (Y/N) ");
                        //Sprung zur Schleifenprüfung
                        continue;
                    }
                    result = n1 / n2;
                    break;
                default:
                    //Fall, welcher eintrifft, wenn keine valide Rechenoperation ausgewählt wurde
                    Console.WriteLine("\nFehlerhafte Eingabe bei Auswahl der Rechenoperation");
                    Console.WriteLine("Wiederholen? (Y/N) ");
                    continue;

            }

            //Ausgabe des Ergebnisses
            Console.WriteLine($"\nErgebnis: {result}");

            //Frage nach der Wiederholung des Programms
            Console.WriteLine("Wiederholen? (Y/N) ");
            //Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
    }
}