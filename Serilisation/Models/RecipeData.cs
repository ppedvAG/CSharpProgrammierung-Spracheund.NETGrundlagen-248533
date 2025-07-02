using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serilisation.Models
{
    // Beachte, dass Properties mit Großbuchstaben beginnen sollten
    public class RecipeData
    {
        [JsonPropertyName("id")]
        [XmlAttribute("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        // usw.
        public string[] ingredients { get; set; }
        public string[] instructions { get; set; }
        public int prepTimeMinutes { get; set; }
        public int cookTimeMinutes { get; set; }
        [XmlAttribute("servings")]
        public int servings { get; set; }
        public string difficulty { get; set; }
        public string cuisine { get; set; }
        public int caloriesPerServing { get; set; }
        public string[] tags { get; set; }

        [XmlIgnore]
        public int userId { get; set; }
        public string image { get; set; }
        public float rating { get; set; }
        public int reviewCount { get; set; }
        public string[] mealType { get; set; }

        public override string ToString()
        {
            return $"{Name} ({cuisine}, {difficulty}, {rating})";
        }
    }
}
