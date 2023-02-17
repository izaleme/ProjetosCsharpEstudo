using System;
using System.Collections.Generic;

namespace _07Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            Console.WriteLine("Elementos:");

            // Inserindo elementos na lista: Add ou Insert
            list.Add("Venti");  // posição 0
            list.Add("Kazuha"); 
            list.Add("Xingqiu");
            list.Add("Gorou");          // O Add insere elementos no fim da lista
            list.Insert(4, "Xiao");     // O Insert insere elementos na posição que vc quiser

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Medir o tamanho da lista: Count
            Console.WriteLine("\nTotal de elementos: " + list.Count);
            Console.WriteLine("\n---------------------------------");

            // Encontrar o primeiro elemento da lista que satisfaça um predicado: list.Find
            string encontraPrimeiro = list.Find(x => x[0] == 'X');     // => Expressão lâmbda
            Console.WriteLine("Primeiro elemento que começa com 'X': " + encontraPrimeiro);

            // Encontrar o último elemento da lista que satisfaça um predicado: list.FindLast
            string encontraUltimo = list.FindLast(x => x[0] == 'X');
            Console.WriteLine("\nÚltimo elemento que começa com 'X': " + encontraUltimo);

            // Encontrar primeira posição de um elemento da lista que satisfaça um predicado: list.FindIndex
            int posicaoPrimeiro = list.FindIndex(x => x[0] == 'X');
            Console.WriteLine("\nPrimeira posição de um elemento que começa com 'X': " + posicaoPrimeiro);

            // Encontrar última posição de um elemento da lista que satisfaça um predicado: list.FindLastIndex
            int posicaoUltimo = list.FindLastIndex(x => x[0] == 'X');
            Console.WriteLine("\nÚltima posição de um elemento que começa com 'X': " + posicaoUltimo);

            // Filtrar a lista com base em um predicado: list.FindAll
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Elementos com 5 caracteres:");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // --------------------------------------------------------------------
            // Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

            list.Remove("Venti");   // Remove um elemento específico
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Lista após remover elementos:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'X');   // Remove todos os elementos que começam com X
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Lista após remover elementos:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);       // Remove o elemento na posição passada
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Lista após remover elementos:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Adicionando elementos para o teste de RemoveRange
            list.Add("Teste 1");
            list.Add("Teste 2");
            list.Add("Teste 3");
            list.Add("Teste 4");

            list.RemoveRange(2, 2);     // Remove 2 elementos a partir da posição 2
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Lista após remover elementos:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
