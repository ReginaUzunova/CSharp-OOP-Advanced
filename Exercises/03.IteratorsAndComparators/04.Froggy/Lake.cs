using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int[] elements;

        public Lake(int[] elements)
        {
            this.elements = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return elements[i];
                }
            }

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return elements[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
