using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Items;

namespace exercise.main.Interfaces
{
    public interface IFillable
    {
        public List<Filling> Fillings { get; }

        public void AddFillings(Filling filling)
        {

        }
    }
}
