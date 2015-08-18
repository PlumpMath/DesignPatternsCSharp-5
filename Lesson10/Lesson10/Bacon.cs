using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Bacon : Decorator
    {
        public Bacon(SandwichComponent component)
            : base(component)
        {
            _name = "Bacon";
            _price = .50m;
        }
    }
}
