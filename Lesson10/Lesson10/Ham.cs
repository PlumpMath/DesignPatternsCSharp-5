using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Ham : Decorator
    {
        public Ham(SandwichComponent componet)
            : base(componet)
        {
            _name = "Ham";
            _price = 2.00m;
        }
    }
}
