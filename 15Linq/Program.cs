using System;
using System.Collections.Generic;
using Linq.Entities;
using System.Globalization;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employees> employees = new List<Employees>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employees(name, email, salary));
                }
            }

            Console.Write("Digite um valor: R$");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var res1 = from p in employees
                       where p.Salary > valor
                       select p.Email;

            Console.WriteLine("Email dos funcionários que ganham mais que R$" + valor.ToString("F2", CultureInfo.InvariantCulture) + ":");
            foreach (string item in res1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var res2 = (from p in employees
                       where p.Name[0] == 'M'
                       select p.Salary).Sum();

            Console.WriteLine("Soma dos salários dos funcionários cujo nome começa com a letra 'M': R$" + res2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}