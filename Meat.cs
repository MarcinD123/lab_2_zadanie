using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Meat : Product
    {
        public double weight;
       
        public double Weight { get; set; }
        public Meat(string name,double weight):base (name)
        {          
            Weight = weight;
        }
    }
}
