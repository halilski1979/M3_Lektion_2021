using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Ivan");
            Person p3 = new Person("Pesho",23);
           

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);



            Person p4 = new Person("Tonii", 23);
            p4.Kids.Add("Ani");
            p4.Kids.Add("Aleks");
            p4.Kids.Add("Asen");
            Console.WriteLine("=============");

            foreach (var item in p4.Kids)
            {
                Console.WriteLine(item);
            }

        }
    }
}
