using System.Text.Json.Serialization;

namespace wallpaper_manager.Models
{
    public class PixabayImage
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("pageURL")]
        public string PageURL { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("previewURL")]
        public string PreviewURL { get; set; }

        [JsonPropertyName("previewWidth")]
        public int PreviewWidth { get; set; }

        [JsonPropertyName("previewHeight")]
        public int PreviewHeight { get; set; }

        [JsonPropertyName("webformatURL")]
        public string WebformatURL { get; set; }

        [JsonPropertyName("webformatWidth")]
        public int WebformatWidth { get; set; }

        [JsonPropertyName("webformatHeight")]
        public int WebformatHeight { get; set; }

        [JsonPropertyName("largeImageURL")]
        public string LargeImageURL { get; set; }

        [JsonPropertyName("imageWidth")]
        public int ImageWidth { get; set; }

        [JsonPropertyName("imageHeight")]
        public int ImageHeight { get; set; }

        [JsonPropertyName("imageSize")]
        public int ImageSize { get; set; }

        [JsonPropertyName("views")]
        public int Views { get; set; }

        [JsonPropertyName("downloads")]
        public int Downloads { get; set; }

        [JsonPropertyName("collections")]
        public int Collections { get; set; }

        [JsonPropertyName("likes")]
        public int Likes { get; set; }

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }

        [JsonPropertyName("userImageURL")]
        public string UserImageURL { get; set; }

        [JsonPropertyName("noAiTraining")]
        public bool NoAiTraining { get; set; }
    }
}
