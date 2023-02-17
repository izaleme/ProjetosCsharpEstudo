using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("** Bem vindo ao programa de criação de matrizes **");
            Console.Write("\nDigite o número de linhas e colunas da matriz: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] matriz = new int[m, n];

            Console.WriteLine("\n++ Montando a matriz:");
            for (int i = 0; i < m; i++)
            {
                Console.Write("Digite os valores da linha #" + i + ": ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(values[j]);
                }
            }

            Console.Write("\nEscolha um número da matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] == x)
                    {
                        Console.WriteLine("\nPosition " + i + "," + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + i]);
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
