using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;
        private List<string> kids = new List<string>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value;}
        }
        
        public List<string> Kids
        {
            get { return kids; }
            set { kids = value; }
        }
        
        //Празен конструктор
        public Person()
        { }

        //Коснтруктор с един параметър
        public Person(string name)
        {
            this.name = name;
        }
        
        //Коснтруктор с един параметър
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"My name is {name}. I am {age} age old.";     
        }
    }
}
