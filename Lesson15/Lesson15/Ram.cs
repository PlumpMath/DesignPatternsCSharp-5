using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class Ram : IProduct
    {
        private decimal _price;

        private delegate void PriceUpdate(IProduct product);
        private event PriceUpdate OnPriceUpdate;

        public Ram(decimal price)
        {
            _price = price;
        }
        public string Name
        {
            get { return "RAM"; }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                Notify(value);
            }
        }

        public void Notify(decimal price)
        {
            _price = price;

            if (OnPriceUpdate != null)
            {
                OnPriceUpdate(this);
            }
        }

        public void AddFollower(ICustomer customer)
        {
            OnPriceUpdate += customer.Update;
        }

        public void RemoveFollower(ICustomer customer)
        {
            OnPriceUpdate -= customer.Update;

        }
    }
}
