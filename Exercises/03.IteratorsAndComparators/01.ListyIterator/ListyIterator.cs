

namespace ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class ListyIterator<T> : IListyIterator<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> list)
        {
            this.list = list;
            this.index = 0;
        }

        public bool HasNext()
        {
            if (this.list.Count > this.index + 1)
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (this.index < this.list.Count - 1)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.list[this.index]);
        }
    }
}
