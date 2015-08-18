using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    // concrete Observer
    public class Customer : ICustomer
    {
        public void Update(IProduct product)
        {
            Console.WriteLine("{0} is now at ${1}", product.Name, product.Price);
        }
    }
}
