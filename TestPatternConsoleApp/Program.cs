using Pattern.Strategy;
using System;

namespace TestPatternConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TestPatternConsoleApp from jan arild!");

            StrategyClient stategyClient = new StrategyClient();
            stategyClient.Run();

        }
    }
}
