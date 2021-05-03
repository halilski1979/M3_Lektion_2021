using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_w_1_BankAccount
{
    class BancAccount
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
            set { balance = value;}
        }

        public override string ToString()
        {
            return $"BankAccount is: {id}, Ballance is {balance}";
        }
    }
}
