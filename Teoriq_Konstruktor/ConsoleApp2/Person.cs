using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        private string name;
        private int age;

        //1. Заделяме задължително памет, без значение дали ни трябва или не
        //private List<string> kids = new List<string>();

        private List<string> kids;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<string> Kids
        {
            get { return kids; }
            set { kids = value; }
        }

        
            //Празен конструктор
        public Person()
        {

        }

        //Коснтруктор с един параметър
        public Person(string name)
        {
            this.name = name;
            this.kids = new List<string>();
        }

        //Коснтруктор с един параметър
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.kids = new List<string>();
        }

        //Коснтруктор с всички параметър
        public Person(string name, int age, List<string> kids)
        {
            this.name = name;
            this.age = age;
            this.kids = kids; 
        }

        public override string ToString()
        {
            return $"My name is {name}. I am {age} age old.";
        }
    }
}
