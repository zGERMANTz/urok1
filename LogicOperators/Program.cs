using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * && сокращенное  и 
             * || сокращенное  или
             * &  и
             * |  или 
             * ! НЕ (унарный)
             */

            bool name =true;
            if (!name)
            {
                Console.WriteLine("у тебя спид");
            }
            else
            {
                Console.WriteLine("NO у тебя спид");
            }
        }
    }
}
