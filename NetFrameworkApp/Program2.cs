using System;

namespace NetFrameworkApp
{
    class Program2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World from NetFrameworkApp!");
            System.Console.WriteLine(Environment.Version);

            {
                // Works with Net Standard library with added
                // references in Nuget to
                // System.Console and System.Runtime.
                var c = new NetStandardLib.Class1();
                var r = c.Fun1();
            }

            {
                // Currently not possible--cannot link/add reference to library.
                //var c = new NetCoreLib.Class1();
                //var r = c.Fun1();
            }

            {
                // Works out of box.
                var c = new NetFrameworkLib.Class1();
                var r = c.Fun1();
            }

            {
                // Works with Net Standard library with added
                // references in Nuget to
                // System.Console and System.Runtime.
                var c = new NetStandardCore.Class1();
                var r = c.Fun1();
            }

            {
                // Works out of box because the Net Framework target is generated.
                var c = new NetStandardFramework.Class1();
                var r = c.Fun1();
            }
        }
    }
}
