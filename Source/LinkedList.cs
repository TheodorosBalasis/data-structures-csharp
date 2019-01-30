using System;
using System.Linq;

namespace DataStructures.Source
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> firstNode { get; set; } = null;

        /// <exception cref="System.IndexOutOfRangeException"> 
        /// Thrown if the index is less than 0 or
        /// greater than or equal to the list size.
        /// </exception>
        public T this[int i]
        {
            get
            {
                if (i >= Count || i < 0)
                    throw new IndexOutOfRangeException();

                var node = firstNode;

                for (var j = 0; j < i; j++)
                    node = node.NextNode;

                return node.Data;
            }
            set
            {
                if (i > Count || i < 0)
                    throw new IndexOutOfRangeException();

                var node = firstNode;

                for (var j = 0; j < i; j++)
                    node = node.NextNode;

                var previousNode = node.PreviousNode;
                var newNode = new LinkedListNode<T>(value, previousNode, node);
                previousNode.NextNode = newNode;
                node.PreviousNode = newNode;
            }
        }

        public int Count
        {
            get
            {
                var count = 0;

                for (var node = firstNode; node != null; node = node.NextNode)
                    count++;

                return count;
            }
        }

        public LinkedList () { }

        public LinkedList (T[] initialElements)
        {
            if (initialElements.Length == 0)
                return;

            firstNode = new LinkedListNode<T>(initialElements[0]);
            var lastNode = firstNode;

            foreach (var element in initialElements.TakeLast(initialElements.Length - 1))
            {
                var newNode = new LinkedListNode<T>(element);
                newNode.PreviousNode = lastNode;
                lastNode.NextNode = newNode;
                lastNode = newNode;
            }
        }

        public void Add (T element)
        {
            var newNode = new LinkedListNode<T>(element);

            if (firstNode != null)
            {
                var lastNode = firstNode;

                for (var node = firstNode; node != null; node = node.NextNode)
                    lastNode = node;

                newNode.PreviousNode = lastNode;
                lastNode.NextNode = newNode;
            }
            else
                firstNode = newNode;
        }

        /// <exception cref="System.IndexOutOfRangeException"> 
        /// Thrown if the index is less than 0
        /// or greater than the list size.
        /// </exception>
        public void Insert (T element, int index)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();

            var newNode = new LinkedListNode<T>(element);

            if (index == 0)
            {
                if (firstNode != null)
                {
                    newNode.NextNode = firstNode;
                    firstNode.PreviousNode = newNode;
                    firstNode = newNode;
                }
                else
                    firstNode = newNode;
            }
            else if (index == Count)
            {
                var lastNode = firstNode;

                for (var node = firstNode; node != null; node = node.NextNode)
                    lastNode = node;

                lastNode.NextNode = newNode;
            }
            else
            {
                var targetNode = firstNode;

                for (var i = 0; i < index; i++)
                    targetNode = targetNode.NextNode;

                newNode.NextNode = targetNode;
                newNode.PreviousNode = targetNode.PreviousNode;

                targetNode.PreviousNode.NextNode = newNode;
                targetNode.PreviousNode = newNode;
            }
        }

        /// <exception cref="System.IndexOutOfRangeException"> 
        /// Thrown if the index is less than 0 or
        /// greater than or equal to the list size.
        /// </exception>
        public void Remove (int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            var node = firstNode;

            for (int i = 0; i < index; i++)
                node = node.NextNode;

            if (index > 0)
                node.PreviousNode.NextNode = node.NextNode;
            if (index < Count - 1)
                node.NextNode.PreviousNode = node.PreviousNode;
            if (index == 0)
                firstNode = firstNode.NextNode;
        }

        public T[] ToArray ()
        {
            T[] array = new T[Count];
            var node = firstNode;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = node.Data;
                node = node.NextNode;
            }

            return array;
        }
    }
}