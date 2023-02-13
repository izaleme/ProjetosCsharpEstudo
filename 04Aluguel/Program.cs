using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //Estudante aluguel = new Estudante();       // => Instanciação normal
            Estudante[] aluguel = new Estudante[10];     // => Instanciação de array

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = Convert.ToInt32(Console.ReadLine());

                aluguel[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if(aluguel[i] != null)
                    Console.WriteLine(i + ": " + aluguel[i]);
            }

        }
    }
}
