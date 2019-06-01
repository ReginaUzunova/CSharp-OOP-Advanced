using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedDatabase
{
    public interface IPerson
    {
        long Id { get; }

        string Username { get; }
    }
}
