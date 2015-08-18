using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpu = new Cpu(150m);
            var ram = new Ram(50m);
            var cust1 = new Customer();
            var cust2 = new Customer();

            cpu.AddFollower(cust1);
            ram.AddFollower(cust2);

            cpu.Price = 100m;
            ram.Price = 25m;

            Console.Read();
        }
    }
}
