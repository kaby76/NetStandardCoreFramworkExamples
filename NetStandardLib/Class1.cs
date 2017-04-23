using System;
using System.Collections.Generic;

namespace NetStandardLib
{
    public class Class1
    {
        public Class1()
        {
            System.Console.WriteLine("Class1() in NetStandardLib called.");
        }

        public List<int> Fun1()
        {
            return new List<int>() { 1, 10, 3, 11, 5, 12 };
        }
    }
}
