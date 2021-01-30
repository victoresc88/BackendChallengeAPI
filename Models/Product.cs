using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal DailyStandingCharge { get; set; }
        public int ContractLength { get; set; }
        public int Renewable { get; set; }
        public string Status { get; set; }
    }
}
