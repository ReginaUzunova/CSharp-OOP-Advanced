using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public interface IListyIterator<T> 
    {
        bool Move();

        bool HasNext();

        void Print();
    }
}
