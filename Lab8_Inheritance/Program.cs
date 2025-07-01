using Lab8_Inheritance.Fahrzeugpark;
using System.Text;

namespace Lab8_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            //Instanziierung verschiedener Fahrzeuge
            Auto pkw1 = new Auto("Mercedes", 210, 23_000, 5);
            Schiff schiff1 = new Schiff("Titanic", 40, 25_000_000, Schiff.SchiffsTreibstoff.Dampf);
            Flugzeug flugzeug1 = new Flugzeug("Boing", 350, 90_000_000, 9800);

            //Ausgabe der verschiedenen Info()-Methoden
            Console.WriteLine(pkw1.Info());
            Console.WriteLine(schiff1.Info());
            Console.WriteLine(flugzeug1.Info());
        }
    }
}
