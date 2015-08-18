using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Core
{
    public class CreditProcessingService
    {
        public bool HasCreditAvailable(decimal purchasAmount)
        {
            Console.WriteLine("Checked if customer as available credit.");
            return true; // we'll be generous!
        }

        public bool MakePurchase(decimal purchaseAmount)
        {
            Console.WriteLine("Credit processing successful.");
            return true; // processing process always returns true; we have no issues!
        }
    }
}
