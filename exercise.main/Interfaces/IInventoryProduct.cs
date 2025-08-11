using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Interfaces
{
    public interface IInventoryProduct
    {
        public string SKU { get; }
        public float Price { get; }        

        public float GetFinalPrice();
        
    }
}
