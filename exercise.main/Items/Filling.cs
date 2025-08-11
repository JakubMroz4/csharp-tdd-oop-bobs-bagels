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
        private string _name;
        private string _sku;
        private Decimal _price;

        public string SKU { get { return _sku; } }

        public Decimal Price { get { return _price; } }

        public string Name => throw new NotImplementedException();

        public Decimal GetFinalPrice()
        {
            return _price;
        }

        public Filling(string name, string sku, Decimal price)
        {
            _name = name;
            _sku = sku;
            _price = price;
        }
    }
}
