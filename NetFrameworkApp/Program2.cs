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
                var c = new NetStandardLib.Class1();
                var r = c.Fun1();
            }

            {
                // Currently not possible.
                //var c = new NetCoreLib.Class1();
                //var r = c.Fun1();
            }

            {
                var c = new NetFrameworkLib.Class1();
                var r = c.Fun1();
            }

            {
                // Currently not possible.
                //var c = new NetStandardCore.Class1();
                //var r = c.Fun1();
            }

            {
                var c = new NetStandardFramework.Class1();
                var r = c.Fun1();
            }
        }
    }
}
