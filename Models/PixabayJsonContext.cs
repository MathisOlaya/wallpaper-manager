using System.Text.Json.Serialization;

namespace wallpaper_manager.Models
{
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(PixabayResponse))]
    internal partial class PixabayJsonContext : JsonSerializerContext
    {
    }
}
