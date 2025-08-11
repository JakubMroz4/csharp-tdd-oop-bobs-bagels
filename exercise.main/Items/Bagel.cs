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
        private string _sku;
        private float _price;
        private float _discountedPrice;
        private List<Filling> _fillings = new();

        public string SKU { get { return _sku; } }

        public float Price { get { return _price;  } }

        public float DiscountedPrice { get { return _discountedPrice; } }

        List<Filling> IFillable.Fillings { get { return _fillings; } }

        public void SetDiscountPrice(float discountPrice)
        {
            _discountedPrice = discountPrice;
        }

        public float GetFinalPrice()
        {
            float sumFillings = _fillings.Sum(f => f.GetFinalPrice());
            return sumFillings + _price;
        }

        public void AddFillings(Filling filling)
        {
            _fillings.Add(filling);
        }

        public Bagel(string sku, float price) { 
            _sku = sku;
            _price = price;
        }
    }
}
