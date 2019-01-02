using NUnit.Framework;

namespace DataStructures.Tests
{
	[TestFixture, TestOf(typeof(ArrayStack<int>))]
	public class ArrayStackTests
	{
		[Test, Parallelizable]
		public void ConstructorTest () => Assert.That(() => new ArrayStack<int>(null), Throws.ArgumentNullException);

		[Test, Parallelizable]
		public void CountTest1 ()
		{
			var stack = new ArrayStack<int>();

			Assert.That(stack.Count, Is.EqualTo(0));
		}

		[Test, Parallelizable]
		public void CountTest2 ()
		{
			var stack = new ArrayStack<int>(new int[] { 0, 1, 2 });

			Assert.That(stack.Count, Is.EqualTo(3));
		}

		[Test, Parallelizable]
		public void BasicFunctionsTest ()
		{
			var stack = new ArrayStack<int>();

			stack.Push(1);

			Assert.That(stack.Peek, Is.EqualTo(1));
			Assert.That(stack.Pop, Is.EqualTo(1));
		}

		[Test, Parallelizable]
		public void BasicFunctionsExceptionsTest ()
		{
			var stack = new ArrayStack<int>();

			Assert.That(stack.Peek, Throws.InvalidOperationException);
			Assert.That(stack.Pop, Throws.InvalidOperationException);
		}

		[Test, Parallelizable]
		public void ContainsTest ()
		{
			var stack = new ArrayStack<int>(new int[] { 0, 1, 2, 3 });

			Assert.That(stack.Contains(1), Is.True);
		}

		[Test, Parallelizable]
		public void ToArrayTest ()
		{
			var stack = new ArrayStack<int>(new int[] { 0, 1, 2, 3 });

			Assert.That(stack.ToArray, Is.EqualTo(new int[] { 0, 1, 2, 3 }));
		}
	}
}