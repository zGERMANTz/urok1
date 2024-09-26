using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chislo1 = Convert.ToDouble(Console.ReadLine());
            double chislo2 = Convert.ToDouble(Console.ReadLine());
            double chislo3 = Convert.ToDouble(Console.ReadLine());
            double result2 = chislo3 * chislo2 * chislo1;
            double result1 = chislo3 + chislo2 + chislo1;
            Console.WriteLine("ложение " + result1);
            Console.WriteLine("умножение " + result2);
        }
    }
}
