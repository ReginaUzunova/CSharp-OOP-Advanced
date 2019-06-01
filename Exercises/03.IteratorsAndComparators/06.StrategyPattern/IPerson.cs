using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IPerson 
    {
        string Name { get; }

        int Age { get; }
    }
}
