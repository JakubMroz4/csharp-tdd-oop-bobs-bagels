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
        private string _name;
        private string _sku;
        private Decimal _price;
        private Decimal _discountedPrice;

        public string SKU { get { return _sku; } }

        public Decimal Price { get { return _price; } }

        public Decimal DiscountedPrice {  get { return _discountedPrice; } }

        public bool IsDiscounted { get; set; }

        public string Name {  get { return _name; } }

        public Decimal GetFinalPrice()
        {
            return _price;
        }

        public void SetDiscountPrice(Decimal discountPrice)
        {
            _discountedPrice = discountPrice;
        }

        public Coffee(string name, string sku, Decimal price)
        {
            _name = name;
            _sku = sku;
            _price = price;
        }
    }
}
