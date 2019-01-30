using System;
using System.Collections.Generic;

namespace DataStructures.Source
{
    public class BinarySearchTree<T> where T : IComparable
    {
        private BinaryTreeNode<T> root = null;

        public BinarySearchTree () { }

        /// <exception cref="System.InvalidOperationException">
        /// Thrown if any element of the initial collection is a duplicate.
        /// </exception>
        public BinarySearchTree (T[] initialElements)
        {
            foreach (T element in initialElements)
                Insert(element);
        }

        /// <exception cref="System.InvalidOperationException">
        /// Thrown if the element already exists in the tree.
        /// </exception>
        public void Insert (T element)
        {
            if (root == null)
                root = new BinaryTreeNode<T>(element);
            else
                insertRecursive(element, root);
        }

        public T[] ToArrayInOrder ()
        {
            List<T> list = new List<T>();
            toArrayInOrder(list, root);
            return list.ToArray();
        }

        public T[] ToArrayPreOrder ()
        {
            List<T> list = new List<T>();
            toArrayPreOrder(list, root);
            return list.ToArray();
        }

        public T[] ToArrayPostOrder ()
        {
            List<T> list = new List<T>();
            toArrayPostOrder(list, root);
            return list.ToArray();
        }

        private void toArrayInOrder(List<T> list, BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            toArrayInOrder(list, node.Left);
            list.Add(node.Data);
            toArrayInOrder(list, node.Right);
        }

        private void toArrayPreOrder(List<T> list, BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            list.Add(node.Data);
            toArrayPreOrder(list, node.Left);
            toArrayPreOrder(list, node.Right);
        }

        private void toArrayPostOrder(List<T> list, BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            toArrayPostOrder(list, node.Left);
            toArrayPostOrder(list, node.Right);
            list.Add(node.Data);
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