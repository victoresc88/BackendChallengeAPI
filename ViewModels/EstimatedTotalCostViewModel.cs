using Newtonsoft.Json;

namespace BackendChallengeAPI.ViewModels
{
    public class EstimatedTotalCostViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("estimatedConsumption")]
        public double EstimatedConsumption { get; set; }
    }
}
