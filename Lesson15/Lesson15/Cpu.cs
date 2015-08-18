using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    // concrete subject
    class Cpu : IProduct
    {
        private decimal _price;

        private readonly List<ICustomer> _customers = new List<ICustomer>(); 

        public Cpu(decimal price)
        {
            _price = price;
        }

        public string Name
        {
            get { return "CPU"; }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                Notify(value);
            }
        }

        public void AddFollower(ICustomer customer)
        {
            _customers.Add(customer);
        }

        public void RemoveFollower(ICustomer customer)
        {
            _customers.Remove(customer);
        }

        public void Notify(decimal price)
        {
            _price = price;

            foreach (var customer in _customers)
            {
                customer.Update(this);
            }
        }
    }
}
