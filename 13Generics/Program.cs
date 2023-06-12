using System;
using System.Collections.Generic;
using Generics.Entities;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet hashSet= new HashSet();

            hashSet.Alumns("A");
            hashSet.Alumns("B");
            hashSet.Alumns("C");

            Console.WriteLine();
            Console.WriteLine(hashSet.ToString());  // total de estudantes
        }
    }
}
