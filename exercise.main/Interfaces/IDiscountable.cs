using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Interfaces
{
    public interface IDiscountable : IInventoryProduct
    {
        public Decimal DiscountedPrice { get; }
        public bool IsDiscounted { get; set; }

        public void SetDiscountPrice(Decimal discountPrice);

        public Decimal GetSavedAmount();
    }
}
