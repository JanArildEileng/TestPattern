using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Strategy
{
    public class StrategyContext
    {

        public IStrategy Strategy { get; set; }

        public  void DoIt()
        {
            Strategy.DoIt();
        }

    }
}
