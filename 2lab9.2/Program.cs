using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    /*Створити абстрактний клас Currency (валюта) для роботи з грошовими сумами.
Визначити віртуальні функції переведення в гривні і виводу на екран. Реалізувати
похідні класи Yen(японська єна) і Euro (євро) з своїми функціями переведення в
гривні і виводу на екран.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yen to Uah:");
            Currency yen = new Yen(25);
            Console.WriteLine(yen.Change());
            Print yen2 = new Yen(25); 
            yen2.Print();

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            Console.WriteLine("Euro to Uah:");
            Currency euro = new Euro(10);
            Console.WriteLine(euro.Change());
            Print euro2 = new Euro(10);
            euro2.Print();

            Console.ReadKey();
        }
    }
}
