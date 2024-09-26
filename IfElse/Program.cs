using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if (утверждение(истина или ложь) или выражение(также))
             * {
             *      действие 1;
             * {
             * else
             * {
             *      действие 2 
             * }
             */
            Console.WriteLine("имя пациента");
            string name = Console.ReadLine();
            if (name == "илья")
            {
                Console.WriteLine("у тебя спид");
            }
            else
            {
                Console.WriteLine("спида нет");
            }
        }
    }
}
