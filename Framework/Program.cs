using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.LibTest;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123123");

            MyRandom rd = new MyRandom(true);
            rd.Run();

            Console.ReadKey();
        }
    }
}
