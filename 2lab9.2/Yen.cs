using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Yen : Currency, Print
    {
        private double money2;
        private double changed2;


        public double A
        {
            get => money2;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} mustn't be 0!");
                }
            }
        }

        public Yen(double money2)
        {
            this.money2 = money2;

        }

        public double Change()
        {
            changed2 = money2 * 0.23;
            return changed2;
        }



        public void Print()
        {
            changed2 = money2 * 0.23;
            Console.WriteLine("-------------------------");
            Console.Write("Amount of Yen: ");
            Console.WriteLine(changed2);
            Console.WriteLine("-------------------------");
        }

       
    }
}
