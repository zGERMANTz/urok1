using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint chetnoeChislo = 0;
            uint nechetnoeChislo = 0;
            int chetnoeSum = 0;
            int nechetnoeSum = 0;
            Console.WriteLine("введи числа диапозона");
            int currentValue = Convert.ToInt32(Console.ReadLine());
            int limit = Convert.ToInt32(Console.ReadLine());
            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    chetnoeChislo++;
                    chetnoeSum = chetnoeSum + currentValue;
                }
                else
                {
                    nechetnoeChislo++;
                    nechetnoeSum = nechetnoeSum + currentValue;
                }
                currentValue++;
            }
            Console.WriteLine("количество нечетных чисел = " + chetnoeChislo);
            Console.WriteLine("количество нечетных чисел = " + nechetnoeChislo);
            Console.WriteLine("сумма нечетных чисел = " + chetnoeSum);
            Console.WriteLine("сумма четных чисел = " + nechetnoeSum);
            Console.ReadLine();
            
        }
    }
}
