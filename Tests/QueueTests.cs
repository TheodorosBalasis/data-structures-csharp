using System.Collections.Generic;
using DataStructures.Source;
using NUnit.Framework;

namespace DataStructures.Tests
{
    [TestFixture, TestOf(typeof(ArrayQueue<int>))]
    public class ArrayQueueTests
    {
        public static IEnumerable<IQueue<int>> TypeCasesFilled ()
        {
            yield return new ArrayQueue<int>(new int[] { 1, 2, 3 });
            yield return new LinkedQueue<int>(new int[] { 1, 2, 3 });
        }

        public static IEnumerable<IQueue<int>> TypeCasesEmpty ()
        {
            yield return new ArrayQueue<int>();
            yield return new LinkedQueue<int>();
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void CountTest (IQueue<int> queue)
        {
            Assert.That(queue.Count, Is.EqualTo(3));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void CountEmptyTest (IQueue<int> queue)
        {
            Assert.That(queue.Count, Is.EqualTo(0));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void ContainsTrueTest (IQueue<int> queue)
        {
            Assert.That(queue.Contains(2), Is.True);
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void ContainsFalseTest (IQueue<int> queue)
        {
            Assert.That(queue.Contains(4), Is.False);
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void EnqueueTest (IQueue<int> queue)
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.That(queue.ToArray(), Is.EqualTo(new int[] { 1, 2, 3 }));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void DequeueTest (IQueue<int> queue)
        {
            var dequeuedValues = new int[2];

            dequeuedValues[0] = queue.Dequeue();
            dequeuedValues[1] = queue.Dequeue();

            Assert.That(dequeuedValues[0], Is.EqualTo(1));
            Assert.That(dequeuedValues[1], Is.EqualTo(2));
            Assert.That(queue.ToArray(), Is.EqualTo(new int[] { 3 }));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void DequeueExceptionTest (IQueue<int> queue)
        {
            Assert.That(queue.Dequeue, Throws.InvalidOperationException);
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void PeekTest (IQueue<int> queue)
        {
            Assert.That(queue.Peek(), Is.EqualTo(1));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void PeekExceptionTest (IQueue<int> queue)
        {
            Assert.That(queue.Peek, Throws.InvalidOperationException);
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void ToArrayTest (IQueue<int> queue)
        {
            Assert.That(queue.ToArray(), Is.EqualTo(new int[] { 1, 2, 3 }));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void ToArrayEmptyTest (IQueue<int> queue)
        {
            Assert.That(queue.ToArray(), Is.EqualTo(new int[] { }));
        }
    }
}