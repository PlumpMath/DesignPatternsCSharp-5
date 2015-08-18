using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public class CustomClass : IEnumerable<string>
    {
        public string Foo { get; set; }
        public string Bar { get; set; }
        public string Boo { get; set; }

        public IEnumerator<string> GetEnumerator()
        {
            yield return Foo;
            yield return Bar;
            yield return Boo;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
