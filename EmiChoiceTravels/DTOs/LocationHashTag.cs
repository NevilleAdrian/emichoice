using Newtonsoft.Json;

namespace EmiChoiceTravels.DTOs
{
    //type=top_hashtags&term={term}&limit={limit}&source_popularity={source_popularity}&fallback_popularity={fallback_popularity}
    public partial class LocationHashTag
    {
        [JsonProperty("type")]
        public string @Type { get; set; }
        [JsonProperty("term")]
        public string Term { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
        [JsonProperty("source_popularity")]
        public string SourcePopularity { get; set; }
        [JsonProperty("fallback_popularity")]
        public string FallbackPopularity { get; set; }
    }
    public partial class LocationHashTag
    {
        public static LocationHashTag FromJson(string json) => JsonConvert.DeserializeObject<LocationHashTag>(json, Converter.Settings);
    }

    public static class SerializeLocationHashTag
    {
        public static string ToJson(this LocationHashTag self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
