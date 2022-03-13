using Newtonsoft.Json;

namespace Cats.ApiClient.Model.Breed
{
    public class Weight
    {
        [JsonProperty("imperial")]
        public string Imperial { get; set; }

        [JsonProperty("metric")]
        public string Metric { get; set; }
    }
}
