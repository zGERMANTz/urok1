using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka3
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("скока рубасов");
            string rub = Console.ReadLine();
            Console.WriteLine("гривен " + Convert.ToDouble(rub)*2);
            Console.WriteLine("баксов " + Convert.ToDouble(rub) * 100);
            
        }
    }
}
