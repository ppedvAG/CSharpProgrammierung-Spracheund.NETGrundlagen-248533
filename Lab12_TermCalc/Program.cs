using Lab12_TermCalc.Logik;

namespace Lab12_TermCalc
{
    public class Program
    {
        //Füge in die Main()-Methode eine Try/Catch-Mechanik ein, welche mindestens víer verschiedene Exceptions abfängt und dem Benutzer eine
        //sinnvolle Fehlermeldung ausgibt. Etabliere zudem eine Mechanik, welche das Programm im Fehlerfall wiederholt.
        static void Main(string[] args)
        {
            string? yesNo;
            string error;
            do
            {

                string eingabe = GetEingabe();

                var calculator = new Calculator();
                var result = calculator.TryExecute(eingabe, out error);

                if(string.IsNullOrEmpty(error))
                {
                    Console.WriteLine($"\t={result}");

                    Console.WriteLine("Weitere Berechnung durchfuehren? (J/n)");

                    yesNo = Console.ReadLine()?.ToLower(); // in Kleinbuchstaben umwandeln
                } 
                else
                {
                    Console.WriteLine(error);

                    // Berechnung im Fehlerfall wiederholen
                    yesNo = "j";
                }
            } 
            // Wiederholen wenn ein Fehler in der Ausgabe steht oder Benutzer nicht n gedrueckt hat.
            while(yesNo != "n");

        }

        //Codeänderungen sollen nur in der Main()-Methode stattfinden.
        static string GetEingabe()
        {
            Console.WriteLine("Bitte gib einen Term mit zwei Zahlen und einem Grundrechenoperator (+ - * /) ein (z.B.: 25+13):");
            return Console.ReadLine();
        }
    }
}

