using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public static class Discounts
    {
        public static List<Discount> List = new List<Discount> {
            {BgloDiscount()},
            {BglpDiscount()},
            {BgleDiscount()},
            {CofbDiscount()},
        };


        public static Discount BgloDiscount()
        {
            return new Discount(
                new Dictionary<string, int> 
                {
                    {"BGLO", 6}
                },
                new Dictionary<string, decimal>
                {
                    {"BGLO", 0.415m}
                }
            );
        }

        public static Discount BglpDiscount()
        {
            return new Discount(
                new Dictionary<string, int>
                {
                    {"BGLP", 12}
                },
                new Dictionary<string, decimal>
                {
                    {"BGLP", 0.3325m}
                }
            );
        }

        public static Discount BgleDiscount()
        {
            return new Discount(
                new Dictionary<string, int>
                {
                    {"BGLE", 6}
                },
                new Dictionary<string, decimal>
                {
                    {"BGLE", 0.415m}
                }
            );
        }

        public static Discount CofbDiscount()
        {
            return new Discount(
                new Dictionary<string, int>
                {
                    {"COFB", 1},
                    {"BGLP", 1}
                },
                new Dictionary<string, decimal>
                {
                    {"COFB", 0.99m},
                    {"BGLP", 0.26m}
                }
            );
        }
    }
}
