using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.Core
{
    // subject
    public interface IComponentPrice
    {
        decimal CpuPrice { get; }
        decimal RamPrice { get; }
        decimal SsdPrice { get; }
    }
}
