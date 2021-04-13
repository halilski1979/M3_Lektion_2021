using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_w_1_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ivan";
            p1.Age = 25;

            OtherPerson p2 = new OtherPerson();
            p2.name = "Asen";
            p2.age = 24;

            Console.WriteLine($"{p1.Name}=>{p1.Age}");

            p1.IntroduceYourSelf();
            p2.IntroduceYourSelf();
        }
    }
}
