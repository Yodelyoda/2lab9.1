using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public abstract class Currency
    {
        public double money;
        

        public abstract double Change();

        public abstract void Print();

    }
}
