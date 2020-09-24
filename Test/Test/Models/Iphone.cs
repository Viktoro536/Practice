using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Iphone : Phone    
    {
        private string Model { get; set; }
        private string OperationSystem { get; set; }
        public override void Price()
        {

            switch (Memory)
            {
                case 64:
                    price = "100";
                    return ;
                case 128:
                    price = "200";
                    return;
                case 256:
                    price = "300";
                    return;
                default:
                    Console.WriteLine("Memory not full");
                    break;

            }
            throw new NotImplementedException();
        }

    }
}
