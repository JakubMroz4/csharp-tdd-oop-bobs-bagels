using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Exceptions;
using exercise.main.Interfaces;

namespace exercise.main.Items
{
    public class Bagel : IInventoryProduct, IFillable, IDiscountable
    {
        private string _name;
        private string _sku;
        private Decimal _price;
        private Decimal _discountedPrice;
        private List<Filling> _fillings = new();

        public string SKU { get { return _sku; } }

        public Decimal Price { get { return _price;  } }

        public Decimal DiscountedPrice { get { return _discountedPrice; } }

        List<Filling> IFillable.Fillings { get { return _fillings; } }

        public bool IsDiscounted { get; set; }

        public string Name {  get { return _name; } }

        public void SetDiscountPrice(Decimal discountPrice)
        {
            _discountedPrice = discountPrice;
        }

        public Decimal GetFinalPrice()
        {
            var sumFillings = _fillings.Sum(f => f.GetFinalPrice());
            if (IsDiscounted)
                return sumFillings + DiscountedPrice;

            return sumFillings + _price;
        }

        public void AddFillings(Filling filling)
        {
            _fillings.Add(filling);
        }

        public Bagel(string name, string sku, Decimal price) { 
            _name = name;
            _sku = sku;
            _price = price;
            IsDiscounted = false;
        }
    }
}
