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
        // Ambos são considerados ruins e devem ser evitados
        
        static void Main(string[] args)
        {
            // *************************
            // Como seria utilizando ref        => REF FAZ O PARÂMETRO SER UMA REFERÊNCIA PARA A VARIÁVEL ORIGINAL

            /*int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);*/


            // **************************
            // Como seria utilizando out:       => OUT É COMO O REF, MAS NÃO EXIGE A INICIALIZAÃO DA VARIÁVEL ORIGINAL

            int a = 10;
            int triple;

            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
