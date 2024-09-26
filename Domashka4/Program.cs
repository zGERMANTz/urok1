using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("чиселка");
            double chislo = Convert.ToDouble(Console.ReadLine());
            if (chislo %2 == 0)
            {
                Console.WriteLine("ЧЕТНОЕ");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
    }
}
