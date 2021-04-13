using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_w_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВROY NA CHLENOVE NA SEMEYSTVO: ");
            int n = int.Parse(Console.ReadLine());

            Family ivanovi = new Family();

            for (int i = 0; i < n; i++)
            {
               // var linia = Console.ReadLine().Split(' ').ToList();
                Person p1 = new Person();
                Console.Write("Name: ");
                p1.Name = Console.ReadLine();
                Console.Write("Age: ");
                p1.Age = int.Parse(Console.ReadLine());
                //p1.Name = linia[0];
                //p1.Age = int.Parse(linia[1]);

                ivanovi.Chlenove.Add(p1);
             }

            ivanovi.Print();

        }
    }
}
