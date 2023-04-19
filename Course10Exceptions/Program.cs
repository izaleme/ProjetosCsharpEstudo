using System;
using System.Globalization;
using Course10Exceptions.Entities;
using Course10Exceptions.Entities.Exceptions;

namespace Course10Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ** ** INSERINDO DADOS ** ** */
            Console.WriteLine("Enter account data");
            Console.Write("Account number: ");
            int intNumCont = Convert.ToInt32(Console.ReadLine());
            Console.Write("Holder: ");
            string strHolder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double doBalance = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double doWithdraw = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(intNumCont, strHolder, doBalance, doWithdraw);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
