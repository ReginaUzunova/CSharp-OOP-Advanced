using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                list.Add(input);
            }

            double elementValue = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(list);
            int result = box.Compare(elementValue);

            Console.WriteLine(result);
        }
    }
}
