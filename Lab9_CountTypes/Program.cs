using Lab9_CountTypes.Fahrzeugpark;
using System.Text;

namespace Lab9_CountTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            //Arraydeklarierung
            FahrzeugBase[] fahrzeuge = new FahrzeugBase[10];

            //Schleife über das Array zur Befüllung
            for (int i = 0; i < fahrzeuge.Length; i++)
            {
                //Aufruf der Zufallsmethode aus der Fahrzeug-Klasse
                fahrzeuge[i] = FahrzeugBase.GeneriereFahrzeug(i);
            }

            var (pkws, schiffe, flugzeuge) = FahrzeugtypenZaehlen(fahrzeuge);

            //Ausgabe
            Console.WriteLine($"Es wurden {pkws} PKW(s), {flugzeuge} Flugzeug(e) und {schiffe} Schiff(e) produziert.");
            //Ausführung der abstrakten Methode
            fahrzeuge[2].Hupen();




            // Fortgeschrittene Alternative mit Linq (https://docs.microsoft.com/en-us/dotnet/csharp/linq/)
            Console.WriteLine("\nEleganter und kuerzer mit Linq:");
            var fzgArray = Enumerable.Range(0, 10).Select(FahrzeugBase.GeneriereFahrzeug).ToArray();
            int pkwCount = fzgArray.Count(x => x is Auto);
            int schiffCount = fzgArray.Count(x => x is Schiff);
            int flugzeugCount = fzgArray.Count(x => x is Flugzeug);
            Console.WriteLine($"Es wurden {pkwCount} PKW(s), {schiffCount} Flugzeug(e) und {flugzeugCount} Schiff(e) produziert.");
        }

        private static (int pkws, int schiffe, int flugzeuge) FahrzeugtypenZaehlen(FahrzeugBase[] fahrzeuge)
        {
            //Deklarierung/Initialisierung der Zählvariablen
            int pkws = 0, schiffe = 0, flugzeuge = 0;

            //Schleife über das Array zur Identifizierung der Objekttypen
            foreach (var item in fahrzeuge)
            {
                //Ausgabe der ToString()-Methoden
                Console.WriteLine(item);
                //Prüfung des Objektstyps und Hochzählen der entsprechenden Variablen
                if (item == null) Console.WriteLine("Kein Objekt vorhanden");
                else if (item is Auto) pkws++;
                else if (item is Schiff) schiffe++;
                else flugzeuge++;
            }

            return (pkws, schiffe, flugzeuge);
        }
    }
}
