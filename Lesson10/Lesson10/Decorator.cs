using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public abstract class Decorator : SandwichComponent
    {
        protected SandwichComponent _component;
        protected string _name = "";
        protected decimal _price = 0m;

        protected Decorator(SandwichComponent component)
        {
            _component = component;
        }

        public override string Name
        {
            get { return string.Format("{0}, {1}", _component.Name, _name); }
        }

        public override decimal Price
        {
            get { return _component.Price + _price; }
        }

        public virtual SandwichComponent InnerComponent
        {
            get { return _component; }
        }
    }
}
