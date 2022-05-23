using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Euro : Currency, Print
    {
        private double money;
        private double changed;

        public double A
        {
            get => money;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} mustn't be 0!");
                }
            }
        }


        public Euro(double money)
        {
            this.money = money;

        }

        public double Change()
        {
            changed = money * 31.60;
            return changed;
        }



        public void Print()
        {
           
            double changed = money * 31.60;
            Console.WriteLine("-------------------------");
            Console.Write("Amount of Euro: ");
            Console.WriteLine((changed));
            Console.WriteLine("-------------------------");
        }

      
    }
}
