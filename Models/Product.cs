
namespace BackendChallengeAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public double DailyStandingCharge { get; set; }
        public int ContractLength { get; set; }
        public int Renewable { get; set; }
        public string Status { get; set; }
    }
}
