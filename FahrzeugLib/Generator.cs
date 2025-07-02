using Bogus;
using Lab9_CountTypes.Fahrzeugpark;

namespace FahrzeugLib
{
    public class Generator
    {
        private readonly Faker faker = new Faker()
        {
            // Wir setzen einen Seed, um immer die gleichen Zufallsdaten zu erhalten
            Random = new Randomizer(42)
        };

        public FahrzeugBase[] GetFahrzeuge(int anzahl)
        {
            FahrzeugBase[] fahrzeuge = new FahrzeugBase[anzahl];

            for (int i = 0; i < anzahl; i++)
            {
                fahrzeuge[i] = GenerateFahrzeug();
            }

            return fahrzeuge;
        }

        public Auto GenerateFahrzeug()
        {
            var name = $"{faker.Vehicle.Manufacturer()} {faker.Vehicle.Model()}";
            var topSpeed = faker.Random.Int(50, 200);
            var price = faker.Random.Int(10000, 50000);
            var doors = faker.Random.Int(2, 5);

            return new Auto(name, topSpeed, price, doors);
        }
    }
}
