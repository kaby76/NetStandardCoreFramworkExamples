namespace NetFramework461App
{
    class Program2
    {
        static void Main(string[] args)
        {
            var f = new NetStandard14Lib.Class1();
            var g = new NetFramework461LibSubstantial.Class1();
            //var h = new NetCore1Lib.Class1();
            System.Console.WriteLine("Hello World from NetFramework461App!");
        }
    }
}
