using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11.Core;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Payment Method: ");
            var method = Console.ReadLine();

            Computer computer;

            var order = new Order
            {
                AmountOfCores = 4,
                AmountOfRam = 32,
                CpuFrequency = 3.0m,
                DriveType = "ssd"
            };

            var processingService = new OrderProcessingService();


            if (method.ToLower() == "cash")
            {
                computer = processingService.MakeCashPurchase(order, 1500m);
            }
            else
            {
                computer = processingService.MakeCreditPurchase(order);
            }

            GiveComputerToCustomer(computer);

            Console.Read();
        }

        public static void GiveComputerToCustomer(Computer computer)
        {
            Console.WriteLine("Gave computer to customer.");
        }
    }
}
