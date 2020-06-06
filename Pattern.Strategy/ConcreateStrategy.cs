using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Strategy
{
    public class ConcreateStrategy : IStrategy
    {
        public void DoIt()
        {
            Console.WriteLine($"Doit in { nameof(ConcreateStrategy)}");
        }
    }
}
