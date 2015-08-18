using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class WheatBread : Decorator
    {
        public WheatBread(SandwichComponent component)
            : base(component)
        {
            _name = "Wheat Bread";
            _price = 1.00m;
        }
    }
}
