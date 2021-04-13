using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Name = "Ivan";
            p1.Age = 22;
            Console.WriteLine($"{p1.Name}=>{p1.Age}");

            p1.PredstaviSe();
            Console.WriteLine();
        }
    }
}
