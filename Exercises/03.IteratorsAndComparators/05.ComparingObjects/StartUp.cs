using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IPerson> personsList = new List<IPerson>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                string name = input[0];
                string age = input[1];
                string town = input[2];

                IPerson person = new Person(name, age, town);
                personsList.Add(person);

                input = Console.ReadLine().Split();
            }

            int number = int.Parse(Console.ReadLine());

            IPerson personToCompare = personsList[number - 1];

            int equalPeople = 0;
            int differentPeople = 0;

            foreach (var item in personsList)
            {
                int result = personToCompare.CompareTo(item);

                if (result == 0)
                {
                    equalPeople++;
                }
                else
                {
                    differentPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {differentPeople} {personsList.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
