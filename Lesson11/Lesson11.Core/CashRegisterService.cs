using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Core
{
    public class CashRegisterService
    {
        public void OpenDrawer()
        {
            // super technical stuff to open drawer.
            Console.WriteLine("Opened Cash Drawer.");
        }

        public decimal MakeChange(decimal purchaseAmount, decimal givenAmount)
        {
            var amt = givenAmount - purchaseAmount;
            Console.WriteLine(string.Format("Amount Owed Customer: ${0}", amt));
            return amt;
        }
    }
}
