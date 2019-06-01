using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class NameComparator : IComparer<IPerson>
    {
        public int Compare(IPerson x, IPerson y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                result = x.Name.ToLower().First().CompareTo(y.Name.ToLower().First());
            }

            return result;
        }
    }
}
