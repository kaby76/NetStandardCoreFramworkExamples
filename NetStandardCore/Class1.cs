using System;
using System.Collections.Generic;

namespace NetStandardCore
{
    public class Class1
    {
        public Class1()
        {
            System.Console.WriteLine("Class1() in NetStandardCore called.");
        }

        public List<int> Fun1()
        {
            return new List<int>() { 1, 10, 3, 11, 5, 12 };
        }
    }
}
