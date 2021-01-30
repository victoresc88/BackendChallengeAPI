using BackendChallengeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAPI.Helper
{
    public static class MockedProducts
    {
        public static IEnumerable<Product> GetListOfMockedProducts()
        {
            return new List<Product>
            {
                new Product {
                    Id = 101,
                    Supplier = "British Ash",
                    Name = "winter prices",
                    Rate = 0.12,
                    DailyStandingCharge = 0.35,
                    ContractLength = 12,
                    Renewable = 39,
                    Status = "live"
                },
                new Product {
                    Id = 109,
                    Supplier = "British Ash",
                    Name = "black friday prices",
                    Rate = 0.11,
                    DailyStandingCharge = 0.95,
                    ContractLength = 24,
                    Renewable = 39,
                    Status = "expired"
                },
                new Product {
                    Id = 202,
                    Supplier = "LEON",
                    Name = "winter prices",
                    Rate = 0.14,
                    DailyStandingCharge = 0.35,
                    ContractLength = 12 ,
                    Renewable = 95,
                    Status = "live"
                },
                new Product {
                    Id = 211,
                    Supplier = "LEON",
                    Name = "special prices",
                    Rate = 0.115,
                    DailyStandingCharge = 0.25,
                    ContractLength = 24,
                    Renewable = 95,
                    Status = "live"
                },
                new Product {
                    Id = 325,
                    Supplier = "Scottish Bower",
                    Name = "brexit prices",
                    Rate = 0.12,
                    DailyStandingCharge = 0.35,
                    ContractLength = 12,
                    Renewable = 65,
                    Status = "live"
                }
            };
        }
    }
}
