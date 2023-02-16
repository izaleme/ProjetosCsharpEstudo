using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CalculadoraPt2
{
    class Program
    {
        // AULA DE MODIFICADORES DE PARÂMETROS (REF E OUT)

        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(a);
            Console.WriteLine(a);
        }
    }
}
