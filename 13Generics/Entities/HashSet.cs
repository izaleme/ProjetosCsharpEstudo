using System;
using System.Collections.Generic;

namespace Generics.Entities
{
    class HashSet : HashSet<int>
    {
        HashSet<int> alumns = new HashSet<int>();

        public void Alumns(string course)
        {
            Console.Write("\nHow many students for course " + course + "? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as matrículas:");

            for (int i = 0; i < num; i++)
            {
                alumns.Add(int.Parse(Console.ReadLine()));
            }
        }

        public override string ToString()
        {
            return "Total students: " + alumns.Count;
        }
    }
}
