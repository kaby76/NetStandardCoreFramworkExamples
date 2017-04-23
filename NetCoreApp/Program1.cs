using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreApp
{
    class Program1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World from NetCoreApp!");

            {
                var c = new NetStandardLib.Class1(); // currently not possible
                var r = c.Fun1();
            }

            {
                var c = new NetCoreLib.Class1();
                var r = c.Fun1();
            }

            {
                // Not really possible yet to reference pure NET Framework API from NET Core.
                var c = new NetFrameworkLib.Class1();
                //var r = c.Fun1();
            }

            {
                var c = new NetStandardCore.Class1();
                var r = c.Fun1();
            }

            {
                var c = new NetStandardFramework.Class1();
                var r = c.Fun1();
            }

        }
    }
}