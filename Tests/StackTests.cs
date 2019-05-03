using System.Collections.Generic;
using DataStructures.Source;
using NUnit.Framework;

namespace DataStructures.Tests
{
    [TestFixture, TestOf(typeof(ArrayStack<int>))]
    public class ArrayStackTests
    {
        public static IEnumerable<IStack<int>> TypeCasesFilled ()
        {
            yield return new ArrayStack<int>(new int[] { 1, 2, 3 });
        }

        public static IEnumerable<IStack<int>> TypeCasesEmpty ()
        {
            yield return new ArrayStack<int>();
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void CountTest1 (IStack<int> stack)
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void CountTest2 (IStack<int> stack)
        {
            Assert.That(stack.Count, Is.EqualTo(3));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void BasicFunctionsTest (IStack<int> stack)
        {
            stack.Push(1);

            Assert.That(stack.Peek, Is.EqualTo(1));
            Assert.That(stack.Pop, Is.EqualTo(1));
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesEmpty")]
        public void BasicFunctionsExceptionsTest (IStack<int> stack)
        {
            Assert.That(stack.Peek, Throws.InvalidOperationException);
            Assert.That(stack.Pop, Throws.InvalidOperationException);
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void ContainsTest (IStack<int> stack)
        {
            Assert.That(stack.Contains(1), Is.True);
        }

        [Test, Parallelizable, TestCaseSource("TypeCasesFilled")]
        public void ToArrayTest (IStack<int> stack)
        {
            Assert.That(stack.ToArray, Is.EqualTo(new int[] { 1, 2, 3 }));
        }
    }
}