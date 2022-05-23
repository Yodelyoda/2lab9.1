using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Yen : Currency
    {
        private double changed2;


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

        public Yen(double money)
        {
            this.money = money;
          
        }

        public override double Change()
        {
            changed2 = money * 0.23;
            return changed2;
        }

    

        public override void Print()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Amount of Yen: ");
            Console.WriteLine(changed2);
            Console.WriteLine("-------------------------");
        }

    }
}
