namespace DatabaseTests
{
    using NUnit.Framework;
    using System;
    using Database;
    using System.Reflection;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private const int ArraySize = 16;
        private const int setIndex = -1;

        [Test]
        public void EmptyConstructorShouldInitializeData()
        {
            Database database = new Database();

            Type type = typeof(Database);

            var field = (int[])type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "arrayOfIntegers")
                .GetValue(database);

            var lenght = field.Length;

            Assert.That(lenght, Is.EqualTo(ArraySize));
        }

        [Test]
        public void EmptyConstructorShouldInitializeIndex()
        {
            Database database = new Database();

            Type type = typeof(Database);

            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(database);

            Assert.That(indexValue, Is.EqualTo(setIndex));
        }

        [Test]
        public void CtorShouldThrowInvalidOperationExceptionWithLargerArray()
        {
            int[] arr = new int[ArraySize + 1];

            Assert.Throws<InvalidOperationException>(() => new Database(arr));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] {1})]
        [TestCase(new int[] {1, 2, 3})]
        [TestCase(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void CtorShouldSetIndexCorrectly(int[] values)
        {
            Database database = new Database(values);

            Type type = typeof(Database);

            int expectedIndex = values.Length - 1;

            var index = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(database);

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] {1})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void AddShouldIncreaseIndexCorrectly(int[] values)
        {
            Database database = new Database(values);

            Type type = typeof(Database);

            database.Add(16);

            var index = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
               .First(f => f.Name == "index")
               .GetValue(database);

            int expectedIndex = values.Length;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void AddWhenDatabaseIsFullShouldInvalidOperationException()
        {
            int[] arr = new int[16];

            Database database = new Database(arr);

            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }
        
        [Test]
        public void RemoveShouldDecreaseIndex()
        {
            int[] arr = new int[5];

            Database database = new Database(arr);

            Type type = typeof(Database);

            database.Remove();

            var index = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
               .First(f => f.Name == "index")
               .GetValue(database);

            int expectedIndex = arr.Length - 2;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void RemoveFromEmptyDatabaseShouldThrowInvalidOperationException()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
    }
}
