using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Calculadora
{
    class Calculadora
    {
        // Usamos o params quando temos um número indefinido de variáveis
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // Utilizando ref:
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        // Utilizando out:
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
