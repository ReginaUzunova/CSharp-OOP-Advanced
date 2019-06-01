namespace CustomLinkedListTests
{
    using CustomLinkedList;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class LinkedListTests
    {
        private const int Count = 0;
        private const int FirstElementInList = 1;
        private DynamicList<int> list;

        [SetUp]
        public void InitializeBeforeEachTest()
        {
            this.list = new DynamicList<int>();
        }

        [Test]
        public void CtorShouldSetCountToZero()
        {
            Assert.That(list.Count, Is.EqualTo(Count));
        }

        [Test]
        public void IndexOperatorShouldReturnValue()
        {
            list.Add(FirstElementInList);
            int element = list[0];

            Assert.That(element, Is.EqualTo(FirstElementInList));
        }

        [Test]
        public void IndexOperatorShouldSetValue()
        {
            list.Add(FirstElementInList);
            list[0] = 42;

            Assert.That(list[0], Is.EqualTo(42));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        public void IndexOperatorShouldThrowExceptionWhenGetIndexIsInvalid(int index)
        {
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            int returnValue = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => returnValue = list[index]);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        public void IndexOperatorShouldThrowExceptionWhenSetIndexIsInvalid(int index)
        {
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => list[index] = 2);
        }
    }
}
