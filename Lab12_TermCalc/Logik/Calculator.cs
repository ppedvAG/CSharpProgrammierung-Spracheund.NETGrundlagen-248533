using Lab12_TermCalc.Enums;

namespace Lab12_TermCalc.Logik
{
    // Schritt 1: Logik in eigene Klasse extrahieren
    public class Calculator
    {
        // Schritt 3: Testklasse "CalculatorTest" in Testprojekt welches verschiedene eingaben testet
        // Folgende Exceptions treten im Test auf
        // System.ArgumentException
        // System.FormatException
        // System.DivideByZeroException
        // System.NullReferenceException
        // System.OverflowException
        public int TryExecute(string input, out string error)
        {
            // Schritt 2: try-catch bauen um jegliche Art von Fehler abzufangen und auszugeben

            error = string.Empty;
            try
            {
                Term term = new Term(input);
                return Execute(term.ParseEingabe());
            }
            catch (InvalidOperationException ex)
            {
                error = $"{ex.Message}:\n{input}";
            }
            catch (FormatException)
            {
                error = $"Ungueltiges Zeichen in der Eingabe:\n{input}";
            }
            catch (OverflowException)
            {
                error = $"Zahlen zu groß:\n{input}";
            }
            // Besser als diese Art von Exception abzufangen ist es sie bereits in der Programmlogik zu berucksichtigen.
            catch (DivideByZeroException)
            {
                error = $"Division durch 0 nicht erlaubt:\n{input}";
            }
             //catch (ArgumentException)
             //catch (NullReferenceException)
            catch (Exception ex)
            {
                error = $"Ein unerwarteter Fehler ist aufgetreten:\n{ex.GetType().Name}\n{ex.Message}";
                //throw; // throw wirft die Exception an die aufrufende Methode
            }

            return 0;    
        }

        public int Execute(Term term)
        {
            checked // OverflowException berucksichtigen
            {
                switch (term.Operation)
                {
                    case Rechenoperation.Addition:
                        return term.Zahl1 + term.Zahl2;
                    case Rechenoperation.Subtraktion:
                        return term.Zahl1 - term.Zahl2;
                    case Rechenoperation.Multiplikation:
                        return term.Zahl1 * term.Zahl2;
                    default:
                        return term.Zahl1 / term.Zahl2;
                }
            }
        }
    }
}

