using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    public class Product :IThing
    {
        public string name;
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
