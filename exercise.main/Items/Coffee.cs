using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Items
{
    public class Coffee : IInventoryProduct, IDiscountable
    {
        private string _sku;
        private float _price;
        private float _discountedPrice;

        public string SKU { get { return _sku; } }

        public float Price { get { return _price; } }

        public float DiscountedPrice {  get { return _discountedPrice; } }

        public float GetFinalPrice()
        {
            return _price;
        }

        public void SetDiscountPrice(float discountPrice)
        {
            _discountedPrice = discountPrice;
        }

        public Coffee(string sku, float price)
        {
            _sku = sku;
            _price = price;
        }
    }
}
