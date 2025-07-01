# C# Grundlagen - Glossar und Wiederholung

---

## Grundlagen


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

