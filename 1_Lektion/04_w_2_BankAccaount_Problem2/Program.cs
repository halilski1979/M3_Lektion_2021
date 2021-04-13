using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_w_2_BankAccaount_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();

            acc1.ID = 1;
            acc1.Deposit(15);
            //Добавяме сума към баланса
            Console.WriteLine(acc1.Balance);
            //Теглим сума от баланса
            acc1.Withdraw(10);
            Console.WriteLine(acc1.Balance);

            Console.WriteLine(acc1);
        }
    }
}
