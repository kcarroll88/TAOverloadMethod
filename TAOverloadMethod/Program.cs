using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAOverloadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feed me a number!");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Number div = new Number();
            div.NumOne(num1);

            int x = 100;

            Number valueOut = new Number();
            valueOut.valueOut(out x);

            Console.WriteLine("Out is : {0}", x);

            Console.ReadLine();
        }
    }
}
