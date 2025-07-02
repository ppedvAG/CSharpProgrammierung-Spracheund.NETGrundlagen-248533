using CsvHelper;
using Serilisation.Models;
using System.Globalization;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serilisation
{
    internal class Program
    {
        const string FILE_PATH_WINDOWS_ONLY = "Data\\RecipeData.json";

        // Besser Path.Combine(), betriebssystemunabhängig zu sein
        static readonly string FilePath = Path.Combine("Data", "RecipeData.json");

        static void Main(string[] args)
        {
            // Beispiel 1: JSON-Datei lesen
            var recipes = ReadRecipesFromJsonFile();


            // Beispiel 2: Als XML serialisieren
            Console.WriteLine("\n\nRezepte als XML deserialisieren");
            WriteAndReadRecipesAsXml(recipes);


            // Beispiel 3: Als CSV serialisieren
            Console.WriteLine("\n\nRezepte als CSV serialisieren");
            WriteAndReadRecipesAsCsv(recipes);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void WriteAndReadRecipesAsCsv(RecipeData[] recipes)
        {
            using (var writer = new StreamWriter("recipes.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(recipes);
            }

            using (var reader = new StreamReader("recipes.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<RecipeData>().ToArray();
                Console.WriteLine(records[3]);
                Console.WriteLine(records[8]);
                Console.WriteLine(records[12]);
            }
        }

        private static void WriteAndReadRecipesAsXml(RecipeData[] recipes)
        {
            var xml = new XmlSerializer(typeof(RecipeData[]));

            // Dateistrom erzeugen: Diese muessen nach gebrauch automatisch wieder geschlossen werden
            // Hierfuer verwenden wir ein using-Statement, da es den Stream automatisch schliesst
            using(var stream = new FileStream("recipes.xml", FileMode.Create))
            {
                xml.Serialize(stream, recipes);

                // Am Ende wird der Stream geschlossen
            }

            using(var stream = new FileStream("recipes.xml", FileMode.Open))
            {
                var deserializedRecipes = xml.Deserialize(stream) as RecipeData[];

                Console.WriteLine(deserializedRecipes[0]);
                Console.WriteLine(deserializedRecipes[5]);
                Console.WriteLine(deserializedRecipes[15]);
            }

        }

        private static RecipeData[] ReadRecipesFromJsonFile()
        {
            var jsonContent = File.ReadAllText(FilePath);

            Console.WriteLine($"Inhalt von '{FilePath}': \n{jsonContent.Substring(0, 40)}...");

            var recipes = JsonSerializer.Deserialize<RecipeData[]>(jsonContent);

            int i = 0;
            foreach (var recipe in recipes)
            {
                // i++ gibt i zurueck und erhoeht es um 1
                // ++i erhoeht es um 1 und gibt es zurueck
                Console.WriteLine($"Rezept #{++i}: {recipe.Name}");
            }

            RecipeData[] myFavoriteRecipes = [
                recipes[0],
                recipes[5],
                recipes[15]
            ];
            var jsonString = JsonSerializer.Serialize(myFavoriteRecipes, new JsonSerializerOptions
            {
                // JSON Datei formatieren und lesbarer machen
                WriteIndented = true
            });

            File.WriteAllText("myFavoriteRecipes.json", jsonString);

            return recipes;
        }
    }
}
