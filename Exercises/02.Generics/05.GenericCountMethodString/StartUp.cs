using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
               
                list.Add(input);
            }

            string elementValue = Console.ReadLine();

            Box<string> box = new Box<string>(list);
            int result = box.Compare(elementValue);
             
            Console.WriteLine(result); 
        }
    }
}
