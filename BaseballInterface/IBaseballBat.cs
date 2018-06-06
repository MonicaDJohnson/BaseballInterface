using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public interface IBaseballBat
    {
        int WeightInGrams { get; set; }
        void Swing();

    }
}
