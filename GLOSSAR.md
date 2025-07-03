# C# Grundlagen - Glossar und Wiederholung

---

## Grundlagen Programmieren


| Begriff				| Beschreibung							|
| --------------------- | ------------------------------------- |
| Variablen				| Platzhalter: Sie reservieren Speicherplatz und kann ihnen Werte zuweisen |
| Konstanten			| Variablen, dessen Werte nicht verändert werden können. `const float PI = 3.14159` |
| Enums					| Spezielle Werttypen in C#, mit denen man Gruppen von Konstanten definieren kann. |
| (Daten-)Typen			| `int, double, string` usw. bestimmen die Art des Platzhalters, u. a. wie viel Speicher reserviert werden soll und wie die Information im Speicher verarbeitet werden soll. | 
| Primitive Typen		| `bool, byte, int, long, float, double, decimal, char` (werden immer als Kopie weiter gereicht, sog. **Value-Type**) |
| Arrays				| Mehrere Werte in einer Folge mit einer fest definierten Kapazität, z. B. `int[] array = new int[5];` |
| Komplexe Typen		| Arrays, `string` (was ein Array von chars ist), `DateTime` und eigene Objekte (es wird immer die Adresse weiter gereicht, sog. **Reference-Type**) |
| Arithmetische Operatoren | Grundrechenarten: +, -, *, /, %	|
| Bedingungen			| `if`, `else`, `else if`				|
| Schleifen				| `while`, `do while`-Schleife, `for`-Schleife |
| Logische Operatoren	| Und (&&), Oder (||), Negierung (!=), Vergleich (==) und weitere, die aber nicht so häufig sind |
| Casting				| Umwandlung von Werten, z. B. `int` nach `double`. Es können jedoch Informationen verloren gehen, z. B. wenn von `double` nach `int` umwandle. |
| Konvertierung/Parsen	| Umwandlung von Komplexen Typen in andere Typen |
| Funktionen			| Sind eigenständige Codeblöcke, die eine bestimmte Aufgabe ausführen und von beliebigen Stellen im Programm aufgerufen werden können. Sie helfen dabei, Code zu **organisieren** und wiederzuverwenden. |


## Grundlagen OOP

| Begriff				| Code-Snippet				    | Beschreibung							|
| --------------------- | ----------------------------- | ------------------------------------- |
| Klassen				| `class Person { }`			| Sind Baupläne für Objekte und kapseln Logik. Sie enthalten Variablen und Funktionen. |
| Instanz / Objekt		| `Person max = new Person();`	| Ein konkretes Erzeugnis des Bauplans einer Klasse, welche zur Laufzeit im Speicher zu finden ist. |
| Mitglieder / Members	| `class Person { /* Alles hier drin */ }`		| Alle Mitglieder einer Klasse, also Felder, Eigenschaften, Methoden. |
| Felder / Fields		| `private int age = 42;`		| Variablen innerhalb einer Klasse.		|
| Methoden				| `public void SayHello();`		| Funktionen innerhalb einer Klasse.	|
| Konstruktor			| `public Person(int age) { }`	| Spezielle Methode ohne Rückgabewert, welche einmalig bei der **Erzeugung** einer Instanz aufgerufen wird. |
| Default-Konstruktor	| `public Person() { }`			| Parameterloser Konstruktor, der auch vorhanden ist, wenn kein Konstruktor in der Klasse definiert wurde. |
| Eigenschaften			| `public Name { get; set; }`	| Methoden-Paar aus get und set, welches ein sog. "backingfield" setzt und ließt. |
| Backingfield			| `private int age = 42;`		| Ein Feld, welches nach außen hin durch eine Eigenschaft zugänglich gemacht wird. (i.d.R. implizit durch .NET) |
| Vererbung				| `class Koch : Person { }`		| Spezialisierung einer (Basis-)Klasse.	|
| Zugriffsmodifizierer	| `public, protected, private, internal`	| Keywords welche die Sichtbarkeit der Members (Felder, Methoden, usw.) bestimmt. |
| static				| `static string dings;`		| Modifier, welche Members instanzübergreifend verfügbar macht. Es wird nur **einmalig** Speicher reserviert. |
| readonly				| `readonly int[] numbers = [];` | Lässt keine nachträgliche Modifikation eines Feldes zu, d. h. Wert kann nicht neu gesetzt werden. |
| const					| `const float PI = 3.14159`	| Kombination aus `static` und `readonly` ist. |
| Abstrakte Klasse		| `abstract class Base { }`		| Modifier auf Klassenebene verhindert es die Instanzerzeugung von Objekten. |
| Abstrakte Methode		| `abstract void SayHello();` 	| Modifier für Methoden erzwingt, dass abgeleitete Klassen diese implementieren müssen. |
| Interfaces			| `interface IWorker {}`		| Kann wie eine exklusive `abstract class` gesehen werden und ist ein *Vertrag*, was eine Klasse können muss, jedoch nicht wie sie es umsetzt. |
| Generics				| `var list = new List<T>();`   | `T` steht für Typvariable. Typsicherheit wird zur Compile-Zeit gewährleistet. Dadurch wird der verwendete Typ für die Liste dynamisch. |
| Exceptions			| `throw new Exception();`		| Unerwartete Ereignisse oder Fehler, die während der Laufzeit auftreten können und abgefangen werden sollten. |
| try-catch				| `try { } catch(Exception) { }` | Hiermit können wir unerwartete Fehler abfangen. |
| using-Block			| `using var stream = File.Open(...)` | Ein Sprachkonstrukt, was Ressourcen (Dateien, Streams, DB) nach Verwendung wieder freigibt. [Siehe auch IDisposable](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dispose-pattern) |
