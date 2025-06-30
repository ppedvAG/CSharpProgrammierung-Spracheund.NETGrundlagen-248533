#region 1.Aufgabe: Schaltjahr-Rechner

{
    //Abfrage der Eingabe
    Console.WriteLine("Gib das Jahr ein:");
    int input = int.Parse(Console.ReadLine());

    //Deklarierung/Initialisierung der bool-Variablen
    bool isGapYear = false;

    //Prüfung einer Teilbarkeit durch 4
    if (input % 4 == 0)
    {
        //Setzten der Variablen auf true
        isGapYear = true;

        //Prüfung einer Teilbarkeit durch 100
        if (input % 100 == 0)
        {
            //Setzten der Variablen auf false
            isGapYear = false;

            //Prüfung einer Teilbarkeit durch 400
            if (input % 400 == 0)
                //Setzten der Variablen auf true
                isGapYear = true;
        }
    }

    //Ausgabe
    Console.WriteLine($"{input} ist Schaltjahr: {isGapYear}");

    //Alternative (detailiertere) Ausgabe mittels Kurz-Bedingung
    string result = isGapYear ? $"{input} ist ein Schaltjahr." : $"{input} ist kein Schaltjahr.";
    Console.WriteLine(result + "\n\n\n");
}

#endregion

#region 2. Aufgabe: Mini-Lotto

{
    //Deklaration & Initialisierung des Arrays der Gewinnzahlen
    int[] guessingNumbers = { 3, 16, 45, 79, 99 };

    //Abfrage des User-Tipps
    Console.Write("Bitte gib deinen Tipp ab (Ganzzahl zwischen 0 und 100): ");
    int input = int.Parse(Console.ReadLine());

    //Prüfung des Zahlenbereiches des Tipps
    if (input < 0 || input > 100)
        Console.WriteLine("Dein Tipp ist außerhalb des Zahlenbereiches.");
    else
    {
        //Prüfung, ob Tipp eine Gewinnzahl ist und Ausgabe
        if (guessingNumbers.Contains(input))
            Console.WriteLine("Glückwunsch!! Du hast eine der fünf Gewinnzahlen getippt.");
        else
            Console.WriteLine("Leider daneben. Viel Glück beim nächsten Mal.");
    }
}
#endregion