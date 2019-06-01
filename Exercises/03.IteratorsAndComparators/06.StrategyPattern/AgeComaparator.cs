using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class AgeComaparator : IComparer<IPerson>
    {
        public int Compare(IPerson x, IPerson y)
        {
            int result = x.Age.CompareTo(y.Age);

            return result;
        }
    }
}
