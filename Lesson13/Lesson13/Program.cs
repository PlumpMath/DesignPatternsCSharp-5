using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new Television("127.0.0.1", 8080);

            var volume = AquosCommand.Volume(15, tv);

            volume.Execute();

            Console.Read();
        }
    }
}
