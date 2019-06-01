using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public interface IPerson : IComparable<IPerson>
    {
        string Name { get; }

        int Age { get; }
    }
}
