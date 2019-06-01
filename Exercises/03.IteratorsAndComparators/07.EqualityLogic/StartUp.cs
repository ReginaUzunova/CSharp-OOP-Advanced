using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<IPerson> setPersons = new SortedSet<IPerson>();
            HashSet<IPerson> hashPersons = new HashSet<IPerson>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                IPerson person = new Person(name, age);
                setPersons.Add(person);
                hashPersons.Add(person);
            }

            Console.WriteLine(setPersons.Count);
            Console.WriteLine(hashPersons.Count);
        }
    }
}
