using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_w_Statistika_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broy hora: ");
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> hora = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                Person p1 = new Person();
                p1.Name = linia[0];
                p1.Age = int.Parse(linia[1]);
                hora.Add(p1.Name,p1.Age);
            }

            foreach (var item in hora.OrderBy(x=>x.Value).Where(x=>x.Value>30))
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }
        }
    }
}
