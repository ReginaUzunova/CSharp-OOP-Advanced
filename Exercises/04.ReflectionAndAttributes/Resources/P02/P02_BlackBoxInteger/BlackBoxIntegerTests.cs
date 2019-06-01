namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split("_");

            Type type = typeof(BlackBoxInteger);
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo myField = null;

            foreach (var field in fields)
            {
                myField = field;
            }

            var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] {  }, null);
            var instance = constructor.Invoke(null);

            while (input[0] != "END")
            {
                string methodName = input[0];
                int number = int.Parse(input[1]);

                var result = methods.Where(m => m.Name == methodName).FirstOrDefault().Invoke(instance, new object[] { number });
                
                Console.WriteLine(myField.GetValue(instance));

                input = Console.ReadLine().Split("_");
            }
        }
    }
}
