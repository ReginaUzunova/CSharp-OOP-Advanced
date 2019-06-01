using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string fullName = firstLine[0] + " " + firstLine[1];
            string address = firstLine[2];

            string[] secondLine = Console.ReadLine().Split();
            string name = secondLine[0];
            int beer = int.Parse(secondLine[1]);

            string[] numbers = Console.ReadLine().Split();
            int intNumber = int.Parse(numbers[0]);
            double doubleNumber = double.Parse(numbers[1]);

            SpecialTuple<string, string> addressTuple = new SpecialTuple<string, string>(fullName, address);
            SpecialTuple<string, int> beerTuple = new SpecialTuple<string, int>(name, beer);
            SpecialTuple<int, double> numberTuple = new SpecialTuple<int, double>(intNumber, doubleNumber);

            Console.WriteLine(addressTuple);
            Console.WriteLine(beerTuple);
            Console.WriteLine(numberTuple);
        }
    }
}
