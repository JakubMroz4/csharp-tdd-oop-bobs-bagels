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

        public string SKU { get { return _sku; } }

        public float Price { get { return _price; } }

        public float GetFinalPrice()
        {
            return _price;
        }

        public Filling(string sku, float price)
        {
            _sku = sku;
            _price = price;
        }
    }
}
