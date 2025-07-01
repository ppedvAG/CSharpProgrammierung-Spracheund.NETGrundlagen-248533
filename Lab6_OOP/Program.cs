using System.Text;

namespace Lab6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.Unicode;

            //Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            Fahrzeug mercedes = new Fahrzeug("Mercedes", 190, 23000);
            //Ausführen der Info()-Methode des Fahrzeugs und Ausgabe in der Konsole
            Console.WriteLine(mercedes.Info() + "\n");

            //Diverse Methodenausführungen
            mercedes.StarteMotor();
            mercedes.Beschleunige(120);
            Console.WriteLine(mercedes.Info() + "\n");

            mercedes.Beschleunige(300);
            Console.WriteLine(mercedes.Info() + "\n");

            mercedes.StoppeMotor();
            Console.WriteLine(mercedes.Info() + "\n");

            mercedes.Beschleunige(-500);
            mercedes.StoppeMotor();
            Console.WriteLine(mercedes.Info() + "\n");
        }
    }
}
