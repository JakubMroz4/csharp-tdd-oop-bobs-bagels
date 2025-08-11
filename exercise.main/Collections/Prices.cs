using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Collections
{
    public static class Prices
    {
        public static Dictionary<string, decimal> SkuToPriceMap = new Dictionary<string, decimal> 
        {
            {"BGLO", 0.49m},
            {"BGLP", 0.39m},
            {"BGLE", 0.49m},
            {"BGLS", 0.49m},
            {"COFB", 0.99m},
            {"COFW", 1.19m},
            {"COFC", 1.29m},
            {"COFL", 1.29m},
            {"FILB", 0.12m},
            {"FILE", 0.12m},
            {"FILC", 0.12m},
            {"FILX", 0.12m},
            {"FILS", 0.12m},
            {"FILH", 0.12m},
        };
    }
}
