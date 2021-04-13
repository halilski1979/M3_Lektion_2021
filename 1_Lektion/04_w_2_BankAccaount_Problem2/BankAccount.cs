using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_w_2_BankAccaount_Problem2
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw (double amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return $"ACCOUNT:{id}   Balance:{balance}";
        }
    }
}
