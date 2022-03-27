using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    public class Person :IThing
    {
        string name;
        int age;
        public string Name { get; set; }
        public int Age { get; set; }

        //ctor
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        internal void Print()
        {
            Console.WriteLine($"Buyer: {Name} ({Age} y.o.) ");
        }
    }
}
