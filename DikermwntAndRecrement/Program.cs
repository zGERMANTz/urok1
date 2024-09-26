using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikermwntAndRecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * инкремент = увелечение значения на единицу
             * декремент = уменьшение на единицу
             */
            // постфисксная 
            int a = 1;
            //инкремент
            //a++;
            int d = 1;
            //декремент
            // d--;
            //префисксная
            int z = 1;
            
            // разница пре и пост в приоритете если пост сначало выбор переменной в консоль и только потом увелечение/уменьшение 
            // а пре сразу делается приоритет наивысщий        
            a = ++a * a;
            //сначала а увеличвается на 1 и получается 4
            Console.WriteLine(a);
            z = z++ * z;
            //сначала умножение 1*1 потом уыелечение на 1 получается 2
            Console.WriteLine(z);
            
        }
    }
}
