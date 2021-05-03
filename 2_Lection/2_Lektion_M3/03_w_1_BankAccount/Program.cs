using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_w_1_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BancAccount acc = new BancAccount();
            acc.ID = 1;
            acc.Balance = 15;

            Console.WriteLine(acc);
            Console.WriteLine($"Account is {acc.ID}, Ballance is: {acc.Balance}");
        }
    }
}
