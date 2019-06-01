using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<IPerson> personsByName = new SortedSet<IPerson>(new NameComparator());
            SortedSet<IPerson> personsByAge = new SortedSet<IPerson>(new AgeComaparator());

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                IPerson person = new Person(name, age);
                personsByName.Add(person);
                personsByAge.Add(person);
            }

            foreach (var item in personsByName)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }

            foreach (var item in personsByAge)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
        }
    }
}
