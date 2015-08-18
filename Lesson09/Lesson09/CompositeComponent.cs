using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    public abstract class CompositeComponent : Component
    {
        protected readonly List<Component> _components = new List<Component>(); 
        protected CompositeComponent(string name, int price)
            : base(name, price) { }

        public override void Add(Component component)
        {
            if (component is Computer)
            {
                throw new Exception("Computer can only be top most object.");
            }
            _components.Add(component);
        }

        public override int Price
        {
            get
            {
                var total = _price;

                foreach (var component in _components)
                {
                    total += component.Price;
                }

                return total;
            }
        }
    }
}
