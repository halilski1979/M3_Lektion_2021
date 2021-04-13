using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_w_Family
{
    class Family
    {
        List<Person> chlenove = new List<Person>();

        public List<Person> Chlenove
        {
            get { return chlenove; }
            set { chlenove = value; }
        }

        public void Print()
        {
            foreach (var item in chlenove.OrderBy(x => x.Name).ThenBy(x=>x.Age))
            {
                Console.WriteLine($"{item.Name} => {item.Age}");
            }
        }


    }
}
