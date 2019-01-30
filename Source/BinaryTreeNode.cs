using System;

namespace DataStructures.Source
{
    public class BinaryTreeNode<T> where T : IComparable
    {
        public BinaryTreeNode<T> Left { get; set; } = null;
        public BinaryTreeNode<T> Right { get; set; } = null;
        public T Data { get; set; } = default(T);

        public BinaryTreeNode () { }

        public BinaryTreeNode (T data) => Data = data;
    }
}