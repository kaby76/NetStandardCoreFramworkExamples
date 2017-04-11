using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NetCore1App
{
    class Program1
    {
        static void Main(string[] args)
        {
            var f = new NetStandard14Lib.Class1();
            var h = new NetCore1Lib.Class1();
            System.Console.WriteLine("Hello World from NetCore1App!");
            var r = f.Fun1();
        }
    }
}