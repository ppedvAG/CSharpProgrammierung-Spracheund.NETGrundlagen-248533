#region Arrays

int[] numbers = new int[5]; // Neues Array mit 5 "Schubladen", d. h. es passen 5 Zahlen hinein
Console.WriteLine(numbers.Length); // Größe des Arrays abfragen: 5

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

// seit C# 12 lassen sich Arrays auch direkt initialisieren
int[] numbers2 = { 1, 2, 3, 4, 5 };
int[] numbers3 = [1, 2, 3, 4, 5];

var sum = numbers.Sum();
Console.WriteLine("Die Summe des Arrays numbers betraegt: " + sum);

var avg = numbers.Average();
Console.WriteLine("Die Durchschnittswert des Arrays numbers betraegt: " + avg);

char[] helloArray = { 'H', 'e', 'l', 'l', 'o' };

// Intern wird ein String in C# als Array von chars verwaltet.
string helloString = "Hello"; // Alternative: new string(helloArray);
Console.WriteLine(helloString);

Console.WriteLine("Vierter Buchstabe von \"Hello\"-Array: " + helloArray[3]); // Ausgabe: l
Console.WriteLine("Vierter Buchstabe von \"Hello\"-String: " + helloString[3]); // Ausgabe: l

// Matrix bzw. 2D-Array (muss immer "rechteckig" sein)
var array2d = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
Console.WriteLine("Element 1,2: " + array2d[1, 2]);

// Arrays verschachteln, also ein Array von Arrays (nicht rechteckig)
// (inkompatibel mit Matrix)
var arrayNested = new int[3][];
arrayNested[0] = new int[2];
arrayNested[1] = new int[3];
arrayNested[2] = new int[4];
Console.WriteLine("Element 1,2: " + arrayNested[1][2]);

#endregion

#region Listen als Alternative zu Arrays

// Listen sind dynamisch, d. h. die initiale Größe muss nicht bestimmt werden

var listOfNumbers = new List<int> { 1, 2, 3 };
listOfNumbers.Add(4);

// "Mehrdimensional", jedoch gibt es bessere Alternativen dazu (nicht empfehlenswert)
var listOfLists = new List<List<int>> { listOfNumbers, listOfNumbers };

#endregion

#region Bedingungen

// Boolsche Operatoren:
// ==, !=, <, >, <=, >=
// Logische Operatoren
// &&, ||, !, ^

int n1 = 4, n2 = 5;
if (n1 == n2)
{
    Console.WriteLine("n1 ist gleich n2");
}
else if (n1 > n2)
{
    Console.WriteLine("n1 ist groesser als n2");
}
else
{
    Console.WriteLine("n1 ist kleiner als n2");
}

var randomInt = Random.Shared.Next(1, 10);

// % ist der Rest der Division
if (randomInt % 2 == 0)
{
    Console.WriteLine("Zufallszahl ist gerade");
}
else
{
    Console.WriteLine("Zufallszahl ist ungerade");
}

#endregion

Console.WriteLine("Beliebige Taste zum Beeenden drücken...");
Console.ReadKey();