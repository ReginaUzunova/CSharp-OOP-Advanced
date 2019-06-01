using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Database
{
    public class Database
    {
        private const int Capacity = 16;
        private int[] arrayOfIntegers;
        private int index;

        public Database()
        {
            this.arrayOfIntegers = new int[Capacity];
            this.index = -1;
        }

        public Database(int[] values)
            :this()
        {
            if (values.Length > 16)
            {
                throw new InvalidOperationException("The array is too long!");
            }

            for (int i = 0; i < values.Length; i++)
            {
                this.arrayOfIntegers[i] = values[i];
            }

            this.index = values.Length - 1;
        }

        public void Add(int element)
        {
            if (this.index < Capacity -1)
            {
                this.arrayOfIntegers[++this.index] = element;
                return;
            }

            throw new InvalidOperationException("The array is full!");
        }

        public void Remove()
        {
            if (this.index == -1)
            {
                throw new InvalidOperationException("The array is empty!");
            }

            this.index--;
        }

        public int[] Fetch()
        {
            return this.arrayOfIntegers.Take(this.index + 1).ToArray();
        }
    }
}
