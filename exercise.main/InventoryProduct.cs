using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class InventoryProduct : IInventoryProduct
    {
        private List<IInventoryProduct> _products;

        public string SKU {  get; }
        public float Price {  get; }
        public float DiscountedPrice { get; }
        public bool IsFilling { get; }
        public List<IInventoryProduct> InventoryProducts { get { return _products; } }

        public InventoryProduct(string sku, float price, bool isFilling) 
        { 
            SKU = sku;
            Price = price;
            IsFilling = isFilling;
        }

        public void SetDiscountPrice(float discountPrice) 
        {
            
        }
    }
}
