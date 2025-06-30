//Variablendeklarierung
int entfernungInMetern, stunden, minuten, sekunden;
double meterProSekunde, kilometerProStunde, meilenProStunde;

//Abfrage der Eingaben
Console.WriteLine("Bitte gib folgende Angaben ein:");
Console.Write("Entfernung (in Metern): ");
//Parsen der Eingabe in Int32
entfernungInMetern = int.Parse(Console.ReadLine());
Console.Write("Stunden: ");
stunden = int.Parse(Console.ReadLine());
Console.Write("Minuten: ");
minuten = int.Parse(Console.ReadLine());
Console.Write("Sekunden: ");
sekunden = int.Parse(Console.ReadLine());

//Ausgabe einer leeren Zeile
Console.WriteLine();

//Berechnung der Ausgaben
sekunden = sekunden + (minuten * 60) + (stunden * 3600);
meterProSekunde = entfernungInMetern / (double)sekunden;
kilometerProStunde = meterProSekunde * 3.6;
meilenProStunde = kilometerProStunde * 0.62137119;

//Ausgaben inkl. Rundungen auf zwei Nachkommastellen
Console.WriteLine($"Meter/Sekunde:\t\t {Math.Round(meterProSekunde, 2)}");
Console.WriteLine($"Kilometer/Stunde:\t {Math.Round(kilometerProStunde, 2)}");
Console.WriteLine($"Meilen/Stunde:\t\t {Math.Round(meilenProStunde, 2)}");