using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    public class Motherboard : CompositeComponent
    {
        public Motherboard(int price)
            : base("Motherboard", price) { }
    }
}
