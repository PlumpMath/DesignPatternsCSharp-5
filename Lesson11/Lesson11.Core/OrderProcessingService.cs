using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Core
{
    public class OrderProcessingService
    {
        private readonly CustomComputerBuilder computerBuilder = new CustomComputerBuilder();
        private readonly HandyDandyComputerStore store = new HandyDandyComputerStore();
        private readonly HandyDandyComputerFactory factory = new HandyDandyComputerFactory();

        public Computer MakeCashPurchase(Order order, decimal amount)
        {
            var register = new CashRegisterService();
            register.OpenDrawer();
            var change = register.MakeChange(order.Price, amount);

            var computer = store.Build(order, computerBuilder);

            factory.PlaceOrder(order);

            return computer;
        }

        public Computer MakeCreditPurchase(Order order)
        {
            var credit = new CreditProcessingService();

            if (!credit.HasCreditAvailable(order.Price))
            {
                throw new Exception("Customer does not have avaiable credit.");
            }


            credit.MakePurchase(order.Price);

            var computer = store.Build(order, computerBuilder);

            factory.PlaceOrder(order);

            return computer;
        }
    }
}
