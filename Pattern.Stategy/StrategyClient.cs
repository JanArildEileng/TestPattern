using System;

namespace Pattern.Stategy
{
    public class StrategyClient
    {
        StrategyContext strategyContext = new StrategyContext();
        public void Run()
        {
            strategyContext.Strategy = new ConcreateStrategy();

            Console.WriteLine($"Hello from { nameof(StrategyClient)}");

            strategyContext.DoIt();

        }

       
    }
}
