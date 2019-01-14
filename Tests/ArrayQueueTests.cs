using DataStructures.Source;
using NUnit.Framework;

namespace DataStructures.Tests
{
	[TestFixture, TestOf(typeof(ArrayQueue<int>))]
	public class ArrayQueueTests
	{
		[Test, Parallelizable]
		public void CountTest ()
		{
			var queue = new ArrayQueue<int>(new int[] { 1, 2, 3 });

			Assert.That(queue.Count, Is.EqualTo(3));
		}

		[Test, Parallelizable]
		public void CountEmptyTest ()
		{
			var queue = new ArrayQueue<int>();

			Assert.That(queue.Count, Is.EqualTo(0));
		}

		[Test, Parallelizable]
		public void ContainsTrueTest ()
		{
			var queue = new ArrayQueue<int>(new int[] { 1, 2, 3 });

			Assert.That(queue.Contains(2), Is.True);
		}

		[Test, Parallelizable]
		public void ContainsFalseTest ()
		{
			var queue = new ArrayQueue<int>(new int[] { 1, 2, 3 });

			Assert.That(queue.Contains(4), Is.False);
		}

		[Test, Parallelizable]
		public void EnqueueTest ()
		{
			var queue = new ArrayQueue<int>();

			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

			Assert.That(queue.ToArray(), Is.EqualTo(new int[] { 1, 2, 3 }));
		}

		[Test, Parallelizable]
		public void DequeueTest ()
		{
			var queue = new ArrayQueue<int>(new int[] { 1, 2, 3 });
			var dequeuedValues = new int[2];

			dequeuedValues[0] = queue.Dequeue();
			dequeuedValues[1] = queue.Dequeue();

			Assert.That(dequeuedValues[0], Is.EqualTo(1));
			Assert.That(dequeuedValues[1], Is.EqualTo(2));
			Assert.That(queue.ToArray(), Is.EqualTo(new int[] { 3 }));
		}

		[Test, Parallelizable]
		public void DequeueExceptionTest ()
		{
			var queue = new ArrayQueue<int>();

			Assert.That(queue.Dequeue, Throws.InvalidOperationException);
		}

		[Test, Parallelizable]
		public void PeekTest ()
		{
			var queue = new ArrayQueue<int>(new int[] { 1, 2, 3 });

			Assert.That(queue.Peek(), Is.EqualTo(1));
		}

		[Test, Parallelizable]
		public void PeekExceptionTest ()
		{
			var queue = new ArrayQueue<int>();

			Assert.That(queue.Peek, Throws.InvalidOperationException);
		}

		[Test, Parallelizable]
		public void ToArrayTest ()
		{
			var queue = new ArrayQueue<int>(new int[] { 1, 2, 3 });

			Assert.That(queue.ToArray(), Is.EqualTo(new int[] { 1, 2, 3 }));
		}

		[Test, Parallelizable]
		public void ToArrayEmptyTest ()
		{
			var queue = new ArrayQueue<int>();

			Assert.That(queue.ToArray(), Is.EqualTo(new int[] { }));
		}
	}
}