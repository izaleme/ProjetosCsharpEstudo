using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            list.Add("Venti");
            list.Add("Kazuha");
            list.Add("Gorou");
            list.Add("Tighnari");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
