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
		public void ContainsTrueTest ()
		{

		}

		[Test, Parallelizable]
		public void ContainsFalseTest ()
		{

		}

		[Test, Parallelizable]
		public void EnqueueTest ()
		{

		}

		[Test, Parallelizable]
		public void EnqueueEmptyTest ()
		{

		}

		[Test, Parallelizable]
		public void DequeueTest ()
		{

		}

		[Test, Parallelizable]
		public void DequeueExceptionTest ()
		{

		}

		[Test, Parallelizable]
		public void PeekTest ()
		{

		}

		[Test, Parallelizable]
		public void PeekExceptionTest ()
		{

		}

		[Test, Parallelizable]
		public void ToArrayTest ()
		{

		}

		[Test, Parallelizable]
		public void ToArrayEmptyTest ()
		{

		}
	}
}