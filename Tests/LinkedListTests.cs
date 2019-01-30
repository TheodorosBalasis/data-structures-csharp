using DataStructures.Source;
using NUnit.Framework;
using System;

namespace DataStructures.Tests
{
    [TestFixture, TestOf(typeof(LinkedList<int>))]
    public class LinkedListTests
    {
        [Test, Parallelizable]
        public void CountTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3, 4 });

            Assert.That(list.Count, Is.EqualTo(4));
        }

        [Test, Parallelizable]
        public void AddTest ()
        {
            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1, 2, 3 }));
        }

        [Test, Parallelizable]
        public void InsertFirstTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3 });

            list.Insert(1, 0);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1, 1, 2, 3 }));
        }

        [Test, Parallelizable]
        public void InsertMiddleTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3 });

            list.Insert(1, 2);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1, 2, 1, 3 }));
        }

        [Test, Parallelizable]
        public void InsertLastTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3 });

            list.Insert(1, 3);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1, 2, 3, 1 }));
        }

        [Test, Parallelizable]
        public void InsertEmptyTest ()
        {
            var list = new LinkedList<int>();

            list.Insert(1, 0);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1 }));
        }

        [Test, Parallelizable]
        public void InsertExceptionTest ()
        {
            var list = new LinkedList<int>();

            Assert.That(() => list.Insert(0, -1), Throws.InstanceOf(typeof(IndexOutOfRangeException)));
            Assert.That(() => list.Insert(0, 1), Throws.InstanceOf(typeof(IndexOutOfRangeException)));
        }

        [Test, Parallelizable]
        public void RemoveFirstTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3 });

            list.Remove(0);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 2, 3 }));
        }

        [Test, Parallelizable]
        public void RemoveMiddleTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3 });

            list.Remove(1);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1, 3 }));
        }

        [Test, Parallelizable]
        public void RemoveLastTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3 });

            list.Remove(2);

            Assert.That(list.ToArray(), Is.EqualTo(new int[] { 1, 2 }));
        }

        [Test, Parallelizable]
        public void RemoveExceptionTest ()
        {
            var list = new LinkedList<int>();

            Assert.That(() => list.Remove(-1), Throws.InstanceOf(typeof(IndexOutOfRangeException)));
            Assert.That(() => list.Remove(0), Throws.InstanceOf(typeof(IndexOutOfRangeException)));
        }

        [Test, Parallelizable]
        public void IndexerValuesTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3, 4 });

            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[2], Is.EqualTo(3));
            Assert.That(list[3], Is.EqualTo(4));
        }

        [Test, Parallelizable]
        public void IndexerExceptionsTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3, 4 });

            Assert.That(() => list[-1], Throws.InstanceOf(typeof(IndexOutOfRangeException)));
            Assert.That(() => list[4], Throws.InstanceOf(typeof(IndexOutOfRangeException)));
        }

        [Test, Parallelizable]
        public void ToArrayTest ()
        {
            var list = new LinkedList<int>(new int[] { 1, 2, 3, 4 });

            Assert.That(list.ToArray, Is.EqualTo(new int[] { 1, 2, 3, 4 }));
        }

        [Test, Parallelizable]
        public void ToArrayEmptyTest ()
        {
            var list = new LinkedList<int>();

            Assert.That(list.ToArray, Is.EqualTo(new int[] { }));
        }
    }
}