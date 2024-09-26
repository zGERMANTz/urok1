using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                int chislo1;
                int chislo2;


                try
                {
                    Console.WriteLine("введи 1ю чиселку");
                     chislo1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("введи 2ю чиселку");
                     chislo2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("число не букву не знак ЧИСЛО");
                    Console.ReadLine();
                    continue;

                }
                Console.WriteLine("введи знак действия");
                string operacia = Console.ReadLine();
                switch (operacia)
                {
                    case "+":
                        Console.WriteLine("сумма = " + (chislo1 + chislo2));
                        break;
                    case "-":
                        Console.WriteLine("разность = " + (chislo1 - chislo2));
                        break;
                    case "*":
                        Console.WriteLine("произведение = " + chislo1 * chislo2);
                        break;
                    case "/":
                        if (chislo2 == 0)

                            Console.WriteLine("какой на ноль делить");

                        else

                            Console.WriteLine("деление = " + chislo1 / chislo2);

                        break;
                    default:
                        Console.WriteLine("ты хуету ввел а не знак");
                        break;
                }
               Console.ReadLine();
            }
        }
    }
}
