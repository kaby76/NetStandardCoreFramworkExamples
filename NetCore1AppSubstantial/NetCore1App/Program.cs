using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NetCore1App
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new NetFramework461LibSubstantial.Class1();
            System.Console.WriteLine("Hello World from NetCore1App!");
            var r = f.Fun1();
            System.Console.WriteLine("list = " + r);
        }
    }
}