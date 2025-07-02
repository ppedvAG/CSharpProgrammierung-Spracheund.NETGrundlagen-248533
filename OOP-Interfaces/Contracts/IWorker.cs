// Mit Namespaces organisieren wir unseren Quellcode
// Empfehlung: Namespaces sollten der Verzeichnisstruktur entsprechen
namespace OOP_Interfaces.Contracts
{
    // Interfaces agieren wie "Vertraege", weil es den Konsumenten Funktionalitaet gewaehrleistet.
    public interface IWorker
    {
        // Interfaces sollten keine Modifier wie public oder private haben
        // Alle Members sind IMMER public
        string Job { get; set; }

        void GoToWork();
    }
}
