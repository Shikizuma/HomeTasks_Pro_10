using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SavingsAccount : BankAccount
    {
        protected override void DoDeposit(decimal amount)
        {
            Console.WriteLine($"Внесення ${amount} на ощадний рахунок.");
        }

        protected override void DoWithdraw(decimal amount)
        {
            Console.WriteLine($"Зняття ${amount} з ощадного рахунку.");
        }

    }
}
