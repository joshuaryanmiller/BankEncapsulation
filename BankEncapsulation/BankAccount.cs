using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;
        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"You have successfully deposited {amount, 0:c}.");
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
