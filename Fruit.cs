using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Fruit : Product
    {
        
        public int count;
        public int Count { get; set; }
        public Fruit(string name, int count):base (name)
        {
            Name = name;
            Count = count;

        }
    }
}
