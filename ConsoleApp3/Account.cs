using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Account
    {
        public string Id { get; }
        public decimal Balance { get; set; }

        public Account() : this(0)
        {
        }

        public Account(decimal balance)
        {
            Id = Guid.NewGuid().ToString();
            Balance = balance;
        }

        public static bool Transfer(Account from, Account to, decimal amount)
        {
            if (from == null || to == null)
            {
                throw new ArgumentNullException("from and to must not be null");
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(" amount must be greate than zero");
            }

            if ( amount > from.Balance)
            {
                return false;
            }
            from.Balance -= amount;
            to.Balance = to.Balance + amount;
            return true;
        }

        public override string ToString()
        {
            return $"ID: {Id} Balance: {Balance}";
        }
    }
}
