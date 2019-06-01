using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public interface IListyIterator<T> : IEnumerable<T>
    {
        bool Move();

        bool HasNext();

        void PrintAll();

        void Print();
    }
}
