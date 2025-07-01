// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
namespace OOP.Models
{
    // Jede Klasse, die wir erstellen, erbt implizit von object
    // Jedes objekt in C# kommt mit folgenden Methoden
    // - Equals() // Logik, ob Objekt mit einem anderen Objekt gleich ist
    // - GetHashCode() // Gibt eine Zahl zurueck, die eindeutig ein Objekt identifiziert
    // - GetType() // Gibt den Typ des Objekts zurueck (nicht wichtig, siehe Fortgeschrittenen Kurs)
    // - ToString() // Gibt eine String-Representation des Objekts zurueck
    public class Creature : object // Nicht ueblich, weil alle Klassen von object ableiten
    {
        #region Fields

        // Mit dem private Modifier schuetzen wir das Feld von Zugriff von außen
        // Felder sollten grundsaezlich IMMER private sein, d. h. von außen nicht zugaenglich sein.
        // Sie sind nur fuer den internen Status relevant.
        private int _age = 0;

        // Protected Felder sind von außen nicht zugaenglich, aber abgeleitete Klassen koennen darauf zugreifen
        protected string _name;

        // Dieses Feld wird auch "Backing-Field" genannt, weil es von einer Eigenschaft gesetzt und gelesen wird
        private string _favoriteFood;

        // Statische Felder sind global verfuegbar und gelten fuer alle Objekte der Klasse
        private static int _numberOfCreatures = 0;

        #endregion

        #region Properties

        // Eigenschaften war ein spezielles Methoden-Paar, was ein Feld gesetzt hat
        // So war das frueher, aber heute absolut unueblich
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string FavoriteFood
        {
            get {  return _favoriteFood; }
            set { _favoriteFood = value; } // Bei der Set-Methode gibt es das Keyword "value", um den Wert zu uebergeben
        }

        // Syntactic Sugar: vereinfachte Kurzform fuer ausgeschriebenes Muster fuer weniger "Boilerplate-Code"
        public string FavoriteDrink { get; set; } // Backing-Field muss nicht explizit definiert werden

        // Syntactic Sugar fuer readonly Properties
        public int Age => _age; // Kurzform, um auf das Alter zuzugreifen

        #endregion

        #region Constructors

        // Default Konstruktor: Wird beim Erzeugen eines Objekts automatisch aufgerufen
        // Konstruktoren haben keinen Return-Typ und haben den selben Namen wie die Klasse
        public Creature()
        {
            // Es gibt immer mindestens ein Konstruktor pro Klasse.
            // Der Default-Konstruktor zeichnet sich dadurch aus, dass er keine Parameter enthaelt
            _name = "unknown";
            _numberOfCreatures++;
        }

        public Creature(string name, int age) 
            : this() // Die Syntax :this() bezeichnet das Aufrufen des Default-Konstruktors
        {
            _name = name;
            _age = age;
        }

        #endregion

        #region Methods

        // Wir koennen Verhalten von der Basisklasse ueberschreibar machen
        // Dafuer muessen die Methoden als solche mit "virtual" gekennzeichnet werden
        public virtual void Talk()
        {
            Console.WriteLine($"Hello my name is {_name} and I am {_age} years old.");
        }

        public void CelebrateBirthday()
        {
            _age++;
            Console.WriteLine($"Happy birthday {_name}! You are now {_age} years old.");
        }

        public static void ShowNumberOfCreatures()
        {
            Console.WriteLine($"There are {_numberOfCreatures} creatures in our program.");
        }

        public override string ToString()
        {
            return $"{_name} is {_age} years old.";
        }

        #endregion
    }
}
