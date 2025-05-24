using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace wallpaper_manager.Models
{
    public class PixabayResponse
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("totalHits")]
        public int TotalHits { get; set; }

        [JsonPropertyName("hits")]
        public List<PixabayImage> Hits { get; set; }
    }
}
