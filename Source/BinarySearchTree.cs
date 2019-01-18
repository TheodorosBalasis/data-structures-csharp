using System;

namespace DataStructures.Source
{
	public class BinarySearchTree<T> where T : IComparable
	{
		private BinaryTreeNode<T> root = null;

		public BinarySearchTree () { }

		public BinarySearchTree (T[] initialElements)
		{

		}

		/// <exception cref="System.InvalidOperationException">
		/// Thrown if the element already exists in the tree.
		/// </exception>
		public void Insert (T element) => insertRecursive(element, root);

		public T[] ToArrayInOrder ()
		{
			throw new NotImplementedException();
		}

		public T[] ToArrayPreOrder ()
		{
			throw new NotImplementedException();
		}

		public T[] ToArrayPostOrder ()
		{
			throw new NotImplementedException();
		}

		private void insertRecursive (T element, BinaryTreeNode<T> node)
		{
			if (node == null)
				return;

			if (node.Data.CompareTo(element) == 0)
				throw new InvalidOperationException("The element already exists!");
			else if (node.Data.CompareTo(element) > 0)
			{
				if (node.Left == null)
					node.Left = new BinaryTreeNode<T>(element);
				else
					insertRecursive(element, node.Left);
			}
			else
			{
				if (node.Right == null)
					node.Right = new BinaryTreeNode<T>(element);
				else
					insertRecursive(element, node.Right);
			}
		}
	}
}