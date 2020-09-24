using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public abstract class Phone : Product
    {
        public string Matrix { get; set; }
        public double Memory { get; set; }
        public double RAM { get; set; }
        public double SizeScreen { get; set; }

        public string price { get; set; }
        public abstract void Price();

    }
}
