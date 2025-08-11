using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Exceptions;

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

            if (_products.Count == _capacity)
                throw new BasketFullException();

            _products.Add(product);
        }

        public void Remove(string SKU)
        {
            if (_products.Count == 0)
                throw new ItemNotInBasketException();

            if (_products.All(p => p.SKU != SKU))
                throw new ItemNotInBasketException();

            var itemToRemove = _products.Where(p => p.SKU == SKU).FirstOrDefault();
            _products.Remove(itemToRemove);
        }

        public void ChangeCapacity(int newCapacity)
        {
            _capacity = newCapacity;
        }

        public float GetTotalCost()
        {
            return _products.Sum(p => p.GetFinalPrice());
        }
    }
}
