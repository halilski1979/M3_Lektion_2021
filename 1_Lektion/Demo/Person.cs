using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Public(Private) -> модификатор на класа 
    //Модификаторите определят видимостта

    public class Person
    {
        //Полета 
        private string name;
        private int age;

        //Свойства на полета

        public string Name
        {
            //метод за четене
            get { return name; }
            //метод за промяна
            set { name = value;}

        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //Метод към класа

        public void PredstaviSe()
        {
            Console.WriteLine($"My name is {name} and I am {age} old");
     //???? Console.WriteLine($"My name is {Name} and I am {Age} old"); 
        }

        
    }
}
