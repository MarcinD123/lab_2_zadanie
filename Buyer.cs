using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Buyer : Person
    {
        //ctor
        public Buyer (string name, int age): base (name, age)
        {          
        }
        public List<Product> tasks { get; set; }
        public void AddProduct(Fruit dupa )
        {
            Console.WriteLine(dupa);

        }
        public void AddProduct(Meat dupa)
        {
            Console.WriteLine(dupa);

        }
        public void RemoveProduct ( int index)
        {
            tasks.RemoveAt(index);
        }
        
        
        internal void Print()
        {
            Console.WriteLine($"Buyer: {Name} ({Age} y.o.) ");
        }

    }
}
