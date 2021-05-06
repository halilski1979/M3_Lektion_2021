using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Toni",25);
                       
            p.Kids.Add("Ani");
            p.Kids.Add("Iva");

            foreach (var item in p.Kids)
            {
                Console.WriteLine(item);
            }

            
            Person p2 = new Person("Katq");
            p2.Kids.Add("Katq1");
            p2.Kids.Add("Katq2");
            p2.Kids.Add("Katq3");

            Console.WriteLine($"Kazvam se {p2.Name} i imam {p2.Kids.Count} deca:");
            foreach (var item in p2.Kids)
            {
                Console.WriteLine(item);
            }



            List<string> deca = new List<string> { "Iva1", "Iva2","Iva3","Iva4"};
            Person p4 = new Person("Iva",20,deca);
            Console.WriteLine($"Kazvam se {p4.Name} i imam {deca.Count} deca:");
            foreach (var item in deca)
            {
                Console.WriteLine(item);
            }



            Person p1 = new Person();
            p1.Kids.Add("Misho");
            p1.Kids.Add("Mira");
            
            //Ще даде грешка, защото в празният конструктор нямаме this.kids = new List<string>();
            foreach (var item in p1.Kids)
            {
                Console.WriteLine(item);
            }


           

        }
    }
}
