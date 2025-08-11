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
        private Decimal _price;
        private Decimal _discountedPrice;

        public string SKU { get { return _sku; } }

        public Decimal Price { get { return _price; } }

        public Decimal DiscountedPrice {  get { return _discountedPrice; } }

        public bool IsDiscounted { get; set; }

        public Decimal GetFinalPrice()
        {
            return _price;
        }

        public void SetDiscountPrice(Decimal discountPrice)
        {
            _discountedPrice = discountPrice;
        }

        public Coffee(string sku, Decimal price)
        {
            _sku = sku;
            _price = price;
        }
    }
}
