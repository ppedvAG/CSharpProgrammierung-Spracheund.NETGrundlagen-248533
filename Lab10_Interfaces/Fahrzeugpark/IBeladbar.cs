namespace Fahrzeugpark
{
    // Aufgabe 1: Interface erstellen
    public interface IBeladbar
    {
        FahrzeugBase Ladung { get; set; }

        bool Belade(FahrzeugBase fahrzeug);

        FahrzeugBase Entlade();
    }
}