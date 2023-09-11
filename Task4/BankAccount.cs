using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class BankAccount
    {
        public void Deposit(decimal amount)
        {
            LogTransaction("Депозит", amount);
            DoDeposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            LogTransaction("Вилучити", amount);
            DoWithdraw(amount);
        }

        private void LogTransaction(string action, decimal amount)
        {
            Console.WriteLine($"Зареєстровано дію: {action} ${amount}.");
        }

        protected abstract void DoDeposit(decimal amount);
        protected abstract void DoWithdraw(decimal amount);
    }
}
