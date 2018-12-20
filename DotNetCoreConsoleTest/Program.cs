using System;
using NetCoreLibraryTest;

namespace DotNetCoreConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NetCoreLibraryTest.Utilities.PrintHelloWorld());

            Console.ReadKey();
        }
    }
}
