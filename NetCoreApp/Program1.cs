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
                // Works out of box.
                var c = new NetStandardLib.Class1(); // currently not possible
                var r = c.Fun1();
            }

            {
                // Works out of box.
                var c = new NetCoreLib.Class1();
                var r = c.Fun1();
            }

            {
                // This is a Net Framework library. So, Microsoft.NETCore.Portable.Compatibility
                // is required.
                var c = new NetFrameworkLib.Class1();
                var r = c.Fun1();
            }

            {
                // This library has both Standard and Core targets.
                // But, I think it links with the Core target.
                var c = new NetStandardCore.Class1();
                var r = c.Fun1();
            }

            {
                // This library has Net Standard target, which is compatible out of box with Net Core.
                var c = new NetStandardFramework.Class1();
                var r = c.Fun1();
            }

        }
    }
}