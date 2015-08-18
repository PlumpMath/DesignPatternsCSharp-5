using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    // observer
    public interface ICustomer
    {
        void Update(IProduct product);
    }
}
