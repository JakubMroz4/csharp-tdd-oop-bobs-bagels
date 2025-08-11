using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Interfaces
{
    public interface IFillable
    {
        public List<IInventoryProduct> Products { get; }

        public void AddFillings(IInventoryProduct filling)
        {

        }
    }
}
