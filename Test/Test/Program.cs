using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var productList = new List<Product>()
            {
                new Iphone () , new Laptop()
            };
            Console.WriteLine(new string('-',100));
            foreach (var item in productList)
            {
                item.Charge();
            }

        }



    }
}
