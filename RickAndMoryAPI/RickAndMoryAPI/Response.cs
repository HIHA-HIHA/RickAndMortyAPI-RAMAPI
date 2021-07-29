using Newtonsoft.Json;

namespace RickAndMoryAPI
{
    public class Response
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("species")]
        public string Species;

        [JsonProperty("gender")]
        public string Gender;

        [JsonProperty("origin")]
        public Origin Origin;


    }
}
