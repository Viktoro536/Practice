using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interface;

namespace Test.Models
{
    public abstract class Product : ICharge
    {


        public void Charge()
        {
            double LevelCharge;
            LevelCharge = int.Parse(Console.ReadLine());
            if (LevelCharge == 100)
            {
                Console.WriteLine("Level charge 100%");
            }
            else if (LevelCharge == 50)
            {
                Console.WriteLine("Level charge 50%");
            }
            else if (LevelCharge < 50)
            {
                Console.WriteLine("Level charge is less than 50%");
            }
            else if (LevelCharge < 20)
            {
                Console.WriteLine("Charge your phone ");
            }

        }
        public virtual double sale()
        {
            return 0;
        }
    }
}
