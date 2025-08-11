using exercise.main.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Discount
    {
        public Dictionary<string, int> ItemRequirementAmountDict;
        public Dictionary<string, Decimal> ItemDiscountedPriceDict;
        public Decimal SavedAmount;
        public Decimal SavingsPercentage;
        public Decimal NewTotalPrice;

        public Discount(Dictionary<string,int> itemRequirementAmountDict, Dictionary<string, Decimal> itemDiscountedPriceDict) 
        { 
            ItemRequirementAmountDict = itemRequirementAmountDict;
            ItemDiscountedPriceDict = itemDiscountedPriceDict;

            SavedAmount = CalculateSavedAmount();
            SavingsPercentage = CalculatePercentageSavedAmount();
            NewTotalPrice = CalculateNewTotal();
        }

        private Decimal CalculateSavedAmount() 
        {
            Decimal oldTotalCost = 0;
            Decimal newTotalCost = 0;

            foreach (var key in ItemRequirementAmountDict.Keys)
            {
                var oldPrice = Prices.SkuToPriceMap.GetValueOrDefault(key);
                var newPrice = ItemDiscountedPriceDict.GetValueOrDefault(key);
                var amount = ItemRequirementAmountDict.GetValueOrDefault(key);

                oldTotalCost += oldPrice * amount;
                newTotalCost += newPrice * amount;
            }

            return oldTotalCost - newTotalCost;
        }

        private Decimal CalculatePercentageSavedAmount()
        {
            Decimal oldTotalCost = 0;
            Decimal newTotalCost = 0;

            foreach (var key in ItemRequirementAmountDict.Keys)
            {
                var oldPrice = Prices.SkuToPriceMap.GetValueOrDefault(key);
                var newPrice = ItemDiscountedPriceDict.GetValueOrDefault(key);
                var amount = ItemRequirementAmountDict.GetValueOrDefault(key);

                oldTotalCost += oldPrice * amount;
                newTotalCost += newPrice * amount;
            }

            return 1 - (oldTotalCost / newTotalCost);
        }

        private Decimal CalculateNewTotal()
        {
            Decimal newTotalCost = 0;

            foreach (var key in ItemRequirementAmountDict.Keys)
            {
                var newPrice = ItemDiscountedPriceDict.GetValueOrDefault(key);
                var amount = ItemRequirementAmountDict.GetValueOrDefault(key);
                newTotalCost += newPrice * amount;
            }

            return newTotalCost;
        }
    }
}
