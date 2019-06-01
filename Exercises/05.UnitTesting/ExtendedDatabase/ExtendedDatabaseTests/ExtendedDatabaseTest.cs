namespace ExtendedDatabaseTests
{
    using NUnit.Framework;
    using System;
    using ExtendedDatabase;
    using System.Reflection;
    using System.Linq;

    [TestFixture]
    public class ExtendedDatabaseTest
    {
        private const int ArraySize = 16;

        private const int NotExistingId = 20;
        private const string NotExistingName = "Me";

        private const int ExistingId = 1;
        private const string ExistingName = "Pesho";

        private IPerson[] people = new Person[]
        {
            new Person(ExistingId, ExistingName),
            new Person(ExistingId + 1, "Gosho"),
        };

        private Database database;

        [SetUp]
        public void InitializeBeforeEachTest()
        {
            this.database = new Database(this.people);
        }

        [Test]
        public void CtorShouldThrowInvalidOperationExceptionWithLargerArray()
        {
            IPerson[] arr = new IPerson[ArraySize + 1];

            Assert.Throws<InvalidOperationException>(() => new Database(arr));
        }

        [Test]
        public void AddPeopleWithSameNameShouldThrowException()
        {
            IPerson person = new Person(NotExistingId, ExistingName);
            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));
        }

        [Test]
        public void AddPeopleWithSameIdShouldThrowException()
        {
            IPerson person = new Person(ExistingId, NotExistingName);
            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));
        }

        [Test]
        public void RemoveExistingPerson()
        {
            this.database.Remove();

            Assert.AreEqual(0, this.database.Index);
        }

        [Test]
        public void FindByUsernameWithNullArgumentShouldThrowExeption()
        {
            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null));
        }

        [Test]
        public void FindByUsernameNameNotExistInCollectionShouldThrowExeption()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername(NotExistingName));
        }

        [Test]
        public void FindByIdWithNegativeNumberShouldThrowException()
        {
            int negativeId = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(negativeId));
        }

        [Test]
        public void FindByIdWithNotExistingIdShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.FindById(NotExistingId));
        }
    }
}
