using DataStructures.Source;
using NUnit.Framework;

namespace DataStructures.Tests
{
    [TestFixture, TestOf(typeof(CircularBuffer<int>))]
    public class CircularBufferTests
    {
        [Test, Parallelizable]
        public void WriteTest ()
        {
            var buffer = new CircularBuffer<int>(new int[] { 1, 2, 3, 4 });

            buffer.Write(5);

            Assert.That(buffer.ToArray(), Is.EqualTo(new int[] { 5, 2, 3, 4 }));
        }

        [Test, Parallelizable]
        public void WriteEmptyTest ()
        {
            var buffer = new CircularBuffer<int>(5);

            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(3);

            Assert.That(buffer.ToArray(), Is.EqualTo(new int[] { 1, 2, 3, 0, 0 }));
        }

        [Test, Parallelizable]
        public void ReadTest ()
        {
            var buffer = new CircularBuffer<int>(new int[] { 1, 2, 3, 4 });

            Assert.That(buffer.Read(), Is.EqualTo(1));
            Assert.That(buffer.Read(), Is.EqualTo(2));
            Assert.That(buffer.Read(), Is.EqualTo(3));
            Assert.That(buffer.Read(), Is.EqualTo(4));
            Assert.That(buffer.Read(), Is.EqualTo(1));
        }

        [Test, Parallelizable]
        public void ToArrayTest ()
        {
            var buffer = new CircularBuffer<int>(new int[] { 1, 2, 3, 4 });

            Assert.That(buffer.ToArray(), Is.EqualTo(new int[] { 1, 2, 3, 4 }));
        }

        [Test, Parallelizable]
        public void ToArrayEmptyTest ()
        {
            var buffer = new CircularBuffer<int>(5);

            Assert.That(buffer.ToArray(), Is.EqualTo(new int[5]));
        }
    }
}