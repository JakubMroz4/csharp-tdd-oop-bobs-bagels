using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Exceptions;

namespace exercise.main
{
    public class Basket
    {
        private int _capacity;
        private List<IDiscountable> _products = new();


        public List<IDiscountable> Products { get { return _products; } }
        public int Capacity { get { return _capacity; } }

        public Basket(int capacity) 
        { 
            _capacity = capacity;
        }

        public void Add(IDiscountable product)
        {
            if (product == null)
                throw new ArgumentNullException();

            if (_products.Count == _capacity)
                throw new BasketFullException();

            _products.Add(product);

            CalculateDiscounts();
        }

        public void Remove(string SKU)
        {
            if (_products.Count == 0)
                throw new ItemNotInBasketException();

            if (_products.All(p => p.SKU != SKU))
                throw new ItemNotInBasketException();

            var itemToRemove = _products.Where(p => p.SKU == SKU).FirstOrDefault();
            _products.Remove(itemToRemove);

            CalculateDiscounts();
        }

        public void ChangeCapacity(int newCapacity)
        {
            _capacity = newCapacity;
        }

        public Decimal GetTotalCost()
        {
            return _products.Sum(p => p.GetFinalPrice());
        }

        private void CalculateDiscounts()
        {
            ResetDiscountedPrices();

            var discounts = new Stack<Discount>(Discounts.List.OrderBy(p => p.SavedAmount));

            var undiscountedItems = _products.Select(p => p).ToList();
            var discountedItems = new List<IDiscountable>();

            while (discounts.Count > 0)
            {
                var discount = discounts.Peek();

                bool missingRequirements = false;
                foreach (var kvp in discount.ItemRequirementAmountDict)
                {
                    var count = undiscountedItems.Count(k => k.SKU == kvp.Key);
                    if (count < kvp.Value)
                    {
                        discounts.Pop();
                        Console.WriteLine("DISCOUNT POPPED");
                        missingRequirements = true;
                        break;
                    }                        
                }

                if (missingRequirements)
                    continue;

                // apply discounted prices if requirement passed
                // move discounted items to new list

                Console.WriteLine("DISCOUNT PASSED");

                foreach (var kvp in discount.ItemRequirementAmountDict) 
                {
                    var newPrice = discount.ItemDiscountedPriceDict.GetValueOrDefault(kvp.Key);
                    var discounted = undiscountedItems.Where(p => p.SKU == kvp.Key).Take(kvp.Value).ToList();
                    discounted.ForEach(p => p.SetDiscountPrice(newPrice));
                    discounted.ForEach(p => p.IsDiscounted = true);
                    discountedItems.AddRange(discounted);

                    var itemsToRemove = undiscountedItems.Where(p => p.SKU == kvp.Key).ToList();
                    itemsToRemove.ForEach(i => undiscountedItems.Remove(i));
                }                
            }

            List<IDiscountable> newProducts = new();
            newProducts.AddRange(undiscountedItems);
            newProducts.AddRange(discountedItems);
            _products = newProducts;
        }

        private void ResetDiscountedPrices()
        {
            _products.ForEach(p => p.IsDiscounted = false);
        }
    }
}
