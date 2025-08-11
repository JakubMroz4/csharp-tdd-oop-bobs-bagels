using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Interfaces
{
    public interface IDiscountable
    {
        public float DiscountedPrice { get; }

        public void SetDiscountPrice(float discountPrice);
    }
}
