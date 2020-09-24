using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Laptop : Product 
    {
        public string Matrix { get; set; }
        public double Memory { get; set; }
        public double RAM { get; set; }
        public double SizeScreen { get; set; }
        public string Name { get; set; }
        private double Cores { get; set; }

    }
}
