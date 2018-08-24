using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAOverloadMethod
{
    class Number
    {
        public void NumOne(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine("Your number divided by 2 is : {0}", result);
        }
        public void valueOut(out int x)
        {
            int temp = 5;
            x = temp;
        }
        public void NumOne(int num1, int num2)
        {
            int result = num1 + num2;
        }
    }
    public static class Math
    {

    }
}
