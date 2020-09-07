using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampleST179
{
    class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;

        public SavingAccount(double balance)
        {
            currBalance = balance;
        }

        public static void SetInterestRate(double newRate)
            => currInterestRate = newRate;

        public static double GetInterestRate()
            => currInterestRate;

        public void PrintState()
           => Console.WriteLine("Curent balance: {0}, Current Interes Rate: {1}", currBalance, currInterestRate);
    }
}
