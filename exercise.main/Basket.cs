using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private int _capacity;
        private List<IInventoryProduct> _products = new();


        public List<IInventoryProduct> Products { get { return _products; } }
        public int Capacity { get { return _capacity; } }

        public Basket(int capacity) 
        { 
            _capacity = capacity;
        }

        public void Add(IInventoryProduct product)
        {
            if (product == null)
                throw new ArgumentNullException();


        }

        public void Remove(string SKU)
        {

        }

        public void ChangeCapacity(int newCapacity)
        {
            _capacity = newCapacity;
        }
    }
}
