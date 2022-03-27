using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Shop : IThing
    {
        public string Name { get; set; }
        List<Person> people = new List<Person>();
        public List<Person> People { get; set; }
        List<Product> products = new List<Product>();
        public Shop(string name, Person[] people, Product[] products)
        {
            Name = name;
            this.people.AddRange(people);
            this.products.AddRange(products);

        }

        internal void Print()
        {
            Console.WriteLine($"Shop {Name}");
            Console.WriteLine("-- People: --");
            foreach (var item in people)
            {
                item.Print();
            }

        }
    }
}
