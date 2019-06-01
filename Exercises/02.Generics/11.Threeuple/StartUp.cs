using System;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string fullName = firstLine[0] + " " + firstLine[1];
            string address = firstLine[2];
            string town = firstLine[3];

            string[] secondLine = Console.ReadLine().Split();
            string name = secondLine[0];
            int beer = int.Parse(secondLine[1]);
            bool isDrunk = secondLine[2] == "drunk" ? true : false;

            string[] bankAccount = Console.ReadLine().Split();
            string accountOwner = bankAccount[0];
            double bankBalance = double.Parse(bankAccount[1]);
            string bankName = bankAccount[2];

            SpecialTuple<string, string, string> addressTuple = new SpecialTuple<string, string, string>(fullName, address, town);
            SpecialTuple<string, int, bool> beerTuple = new SpecialTuple<string, int, bool>(name, beer, isDrunk);
            SpecialTuple<string, double, string> bankTuple = new SpecialTuple<string, double, string>(accountOwner, bankBalance, bankName);

            Console.WriteLine(addressTuple);
            Console.WriteLine(beerTuple);
            Console.WriteLine(bankTuple);
        }
    }
}
