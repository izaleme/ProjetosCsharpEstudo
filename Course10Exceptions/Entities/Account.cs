using Course10Exceptions.Entities.Exceptions;

namespace Course10Exceptions.Entities
{
    class Account
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int numberAccount, string holder, double balance, double withdrawLimit)
        {
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
