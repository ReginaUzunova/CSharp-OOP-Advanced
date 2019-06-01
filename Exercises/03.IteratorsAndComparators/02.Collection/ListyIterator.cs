using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IListyIterator<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> list)
        {
            this.list = list;
            this.index = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
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

        public void PrintAll()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(string.Join(" ", this.list));
        }

        public void Print()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.list[this.index]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
