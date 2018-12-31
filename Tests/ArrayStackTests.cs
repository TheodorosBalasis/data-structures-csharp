using NUnit.Framework;
using DataStructures;

namespace DataStructures.Tests
{
    [TestFixture]
    public class ArrayStackTests
    {
        [Test]
        public void CountTest1()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            
            Assert.That(stack.Count, Is.EqualTo(0));
        }

		[Test]
		public void CountTest2 ()
		{
			ArrayStack<int> stack = new ArrayStack<int>();

			stack.Push(0);
			stack.Push(1);

			Assert.That(stack.Count, Is.EqualTo(2));
		}

        [Test]
        public void PushTest()
        {

        }

        [Test]
        public void PopTest()
        {

        }

        [Test]
        public void PeekTest()
        {

        }

        [Test]
        public void ContainsTest()
        {

        }

        [Test]
        public void ToArrayTest()
        {

        }
    }
}