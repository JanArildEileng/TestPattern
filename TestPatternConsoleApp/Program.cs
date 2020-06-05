using Pattern.Stategy;
using System;

namespace TestPatternConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TestPatternConsoleApp from jan arild!");

            StategyClient stategyClient = new StategyClient();
            stategyClient.Run();

        }
    }
}
