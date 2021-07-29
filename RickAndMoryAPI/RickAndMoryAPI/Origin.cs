using Newtonsoft.Json;

namespace RickAndMoryAPI
{
    public class Origin
    {
        [JsonProperty("name")]
        public string NameLocation;

        [JsonProperty("location")]
        public Location Location;

    }
}
