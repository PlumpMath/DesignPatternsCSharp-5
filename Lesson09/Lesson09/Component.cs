using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    public abstract class Component
    {
        protected readonly string _name;
        protected readonly int _price;
        protected Component(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public virtual void Add(Component component)
        {
            throw new Exception("Component cannot be added to this component.");
        }

        public virtual string Name
        {
            get { return _name; }
        }

        public virtual int Price
        {
            get { return _price; }
        }
    }
}
