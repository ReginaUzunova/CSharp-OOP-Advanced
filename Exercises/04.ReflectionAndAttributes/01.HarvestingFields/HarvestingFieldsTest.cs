namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = typeof(HarvestingFields);

            string input = Console.ReadLine();

            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public |
                BindingFlags.NonPublic);

            while (input != "HARVEST")
            {
                if (input != "all")
                {
                    var fieldsToPrint = fields.Where(f => f.Attributes
                    .ToString()
                    .ToLower()
                    .Replace("family", "protected") == input)
                    .ToArray();

                    foreach (var field in fieldsToPrint)
                    {
                        Console.WriteLine($"{field.Attributes.ToString().ToLower().Replace("family", "protected")} {field.FieldType.Name} {field.Name}");
                    }
                }
                else
                {
                    foreach (var field in fields)
                    {
                        Console.WriteLine($"{field.Attributes.ToString().ToLower().Replace("family", "protected")} {field.FieldType.Name} {field.Name}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
