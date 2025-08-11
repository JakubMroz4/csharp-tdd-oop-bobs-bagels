using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Items
{
    public class Filling : IInventoryProduct
    {
        private string _sku;
        private float _price;

        public string SKU => throw new NotImplementedException();

        public float Price => throw new NotImplementedException();

        public float GetFinalPrice()
        {
            throw new NotImplementedException();
        }

        public Filling(string sku, float price)
        {
            _sku = sku;
            _price = price;
        }
    }
}
