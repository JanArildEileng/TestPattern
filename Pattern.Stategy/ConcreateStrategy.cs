using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Stategy
{
    public class ConcreateStrategy : IStrategy
    {
        public void DoIt()
        {
            Console.WriteLine($"Doit in { nameof(ConcreateStrategy)}");
        }
    }
}
