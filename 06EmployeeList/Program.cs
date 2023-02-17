using System;
using System.Globalization;
using System.Collections.Generic;

namespace _06EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("++++ Cadastro de Funcionários ++++\n");

            Console.Write("How many employees will be registred? ");
            int intRecords = int.Parse(Console.ReadLine());

            for (int i = 1; i <= intRecords; i++)
            {
                Console.WriteLine("\nEmployee #" + i);
                Console.Write("Id: ");
                int intIdEmployee = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string strNameEmployee = Console.ReadLine();
                Console.Write("Salary: ");
                double doSalaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(intIdEmployee, strNameEmployee, doSalaryEmployee));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double doPercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(doPercentage);

                Console.WriteLine("\nUpdated list of Employees:");
                foreach (Employee obj in list)
                    Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

        }
    }
}
