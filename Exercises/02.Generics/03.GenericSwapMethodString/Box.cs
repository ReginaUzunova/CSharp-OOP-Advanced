using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericSwapMethodString
{
    class Box<T>
    {
        public Box(List<T> items)
        {
            this.Items = items;
        }

        public List<T> Items { get; set; }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            T temp = this.Items[firstIndex];
            this.Items[firstIndex] = this.Items[secondIndex];
            this.Items[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Items)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
