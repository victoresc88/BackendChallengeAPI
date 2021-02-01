using Newtonsoft.Json;

namespace BackendChallengeAPI.ViewModels
{
    public class ProductViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("supplier")]
        public string Supplier { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rate")]
        public double Rate { get; set; }
        [JsonProperty("dailystandingcharge")]
        public double DailyStandingCharge { get; set; }
        [JsonProperty("contractlength")]
        public int ContractLength { get; set; }
        [JsonProperty("renewable")]
        public int Renewable { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
