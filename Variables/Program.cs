// Regions werden verwendet um Codebreiche zu gruppieren.
// Sie haben keine Auswirkungen auf den Code.
#region Variablen

int number = 20;
string name = "Max";

int age; // Deklaration
age = 20; // Zuweisung

Console.WriteLine("Name: " + name + " Alter: " + age);

int ageDoubled = age * 2;
Console.WriteLine("Alter verdoppelt: " + ageDoubled);

var theNumber = 42; // Zuweisung bei var ist erforderlich, damit Typ automatisch ermittelt werden kann
var floatNumber = 3.1415f; // Mit dem Suffix f wird die Variable als float deklariert
var doubleNumber = 3.1415; // Ohne Suffix oder mit d wird die Variable als double deklariert
var decimalNumber = 3.1415m; // Mit dem Suffix m wird die Variable als decimal deklariert

// Bei Python und JavaScript egal, aber bei OOP Sprachen wie C# oder Java gibt es diese Unterscheidung.
char c = 'a'; // Char speichert ein einzelnes Zeichen ab. Immer in einfachen Anfuehrungszeichen ('')
string s = "Hello"; // String speichert einen Text ab. Immer in doppelten Anfuehrungszeichen ("")

// Beim Zusammenfuegen von Text werden Zahlen Typen automatisch zu Text umgewandelt.
var composedText = name + " ist " + age + " Jahre alt.";

// Hier werden die Platzhalter {0} und {1} durch die Variablen name und age ersetzt.
var formattedText = string.Format("Name: {0} Alter: {1}", name, age);

// Einfachere Alternative zu string.Format(), indem wir $ als Prefix verwenden.
var interpolatedText = $"Name: {name} Alter: {age}";

#endregion

#region Eingabe

Console.WriteLine("Bitte geben Sie Ihren Namen ein: ");
string input = Console.ReadLine();
Console.WriteLine($"Hello, {input}!");

Console.WriteLine("\nBitte eine beliebige Taste druecken.");
var info = Console.ReadKey();
Console.WriteLine($"\nDie Taste {info.Key} wurde gedrueckt.");

#endregion

#region Konvertierung

var numberAsString = number.ToString();// explizti: 20 und "20" sind nicht das selbe Objekt
numberAsString = $"{number}"; // wird implizit als string konvertiert

//var doubledString = numberAsString * 2; // Compiler meckert, dass das nicht geht
var stringPlus2 = numberAsString + 2; // Das geht, weil auch hier implizit 2 als string konvertiert wird
// Ausgabe: 202

int numberAsInt = int.Parse(numberAsString); // wieder 20 mit dem wir rechnen koennen
var doubledNumber = numberAsInt * 2;

double numberWithPrecision = 2.7182818284590452354;

// Cast, Typecast, Casting: Umwandlung von einer Variable in einen anderen Typen "erzwingen"
int numberWithoutDecimal = (int)numberWithPrecision; // Ausgabe: 2
double doubleWithDecimal = (double)numberWithoutDecimal; // Ausgabe: 2 
// Nachkommastellen werden abgeschnitten und gehen verloren!

#endregion

#region Arithmetik

// Grundrechenarten +, -, *, /, %, ++, --

var even = 42 % 2; // even enthaelt 0 weil Rest 0 ist
var odd = 43 % 2; // odd enthaelt 1 weil Rest 1 ist

number++; // number = number + 1
++number; // number = number + 1

number--; // number = number - 1
--number; // number = number - 1

Math.Floor(4.56); // immer abrunden, unabhaengig von den Nachkommastellen
Math.Ceiling(4.56); // immer aufrunden, unabhaengig von den Nachkommastellen
Math.Round(4.56); // auf- oder abrunden, abhaengig von den Nachkommastellen
Math.Abs(-42); // den Betrag der Zahl zurueckgeben

Math.Max(1, 2); // den groesseren Wert zurueckgeben
Math.Min(1, 2); // den kleineren Wert zurueckgeben

#endregion


Console.WriteLine("Press any key to exit.");
Console.ReadKey();