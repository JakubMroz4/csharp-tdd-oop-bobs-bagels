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
        private List<IInventoryProduct> _fillings;

        public string SKU => throw new NotImplementedException();

        public float Price => throw new NotImplementedException();

        public float DiscountedPrice => throw new NotImplementedException();

        public List<IInventoryProduct> Products => throw new NotImplementedException();

        public void SetDiscountPrice(float discountPrice)
        {
            throw new NotImplementedException();
        }

        public float GetFinalPrice()
        {
            throw new NotImplementedException();
        }

        public void AddFillings(IInventoryProduct filling)
        {
            throw new NotImplementedException();
        }

        public Bagel(string sku, float price) { 
            _sku = sku;
            _price = price;
        }
    }
}
