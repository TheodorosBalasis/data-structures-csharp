using DataStructures.Source;
using NUnit.Framework;

namespace DataStructures.Tests
{
    [TestFixture, TestOf(typeof(BinarySearchTree<int>))]
    public class BinarySearchTreeTests
    {
        [Test, Parallelizable]
        public void InsertTest ()
        {
            var tree = new BinarySearchTree<int>();

            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);

            Assert.That(tree.ToArrayInOrder(), Is.EqualTo(new int[] { 1, 2, 3 }));
        }

        [Test, Parallelizable]
        public void ToArrayInOrderTest ()
        {
            var tree = new BinarySearchTree<int>(new int[] { 1, 2, 3, 4, 5 });

            Assert.That(tree.ToArrayInOrder(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Test, Parallelizable]
        public void ToArrayPreOrderTest ()
        {
            var tree = new BinarySearchTree<int>(new int[] { 1, 2, 3, 4, 5 });

            Assert.That(tree.ToArrayPreOrder(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Test, Parallelizable]
        public void ToArrayPostOrderTest ()
        {
            var tree = new BinarySearchTree<int>(new int[] { 1, 2, 3, 4, 5 });

            Assert.That(tree.ToArrayPostOrder(), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
        }

        [Test, Parallelizable]
        public void ToArrayEmptyTest ()
        {
            var tree = new BinarySearchTree<int>();

            Assert.That(tree.ToArrayInOrder(), Is.EqualTo(new int[] { }));
        }
    }
}