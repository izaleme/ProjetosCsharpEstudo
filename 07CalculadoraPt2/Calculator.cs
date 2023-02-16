using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CalculadoraPt2
{
    class Calculator
    {
        // Como seria utilizando ref:
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        // Como seria utilizando out:
        /*public static void Triple (int origin, out int result)
        {
            result = origin * 3;
        }*/
    }
}
