using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Calculadora
{
    class Program
    {
        // AULA DE MODIFICADORES DE PARÂMETROS (PARAMS, REF E OUT)
        // Ref e Out são considerados ruins e devem ser evitados

        static void Main(string[] args)
        {
            // Numa situação onde precisamos de uma calculadora, o jeito mais eficaz de trabalhar é com arrays
            int result = Calculadora.Sum(10, 20, 30, 40);


            // *********************
            // Utilizando ref        => REF FAZ O PARÂMETRO SER UMA REFERÊNCIA PARA A VARIÁVEL ORIGINAL

            int a = 10;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);


            // *********************
            // Utilizando out:       => OUT É COMO O REF, MAS NÃO EXIGE A INICIALIZAÃO DA VARIÁVEL ORIGINAL

            int b = 10;
            int triple;

            Calculadora.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
