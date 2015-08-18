using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson12.Core;

namespace Lesson12.Server
{
    // real subject
    internal class StoredComponentPrices : IComponentPrice
    {
        public decimal CpuPrice
        {
            get { return 250m; }
        }

        public decimal RamPrice
        {
            get { return 32m; }
        }

        public decimal SsdPrice
        {
            get { return 225m; }
        }
    }
}
