using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Backend.Models
{
    public class OutfitCalendarEntry
    {

        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("selectedOutfit")]
        public List<ClothingItem> SelectedOutfit { get; set; } = new();
    }
}
