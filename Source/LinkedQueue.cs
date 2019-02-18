using System;

namespace DataStructures.Source
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private LinkedList<T> internalList = new LinkedList<T>();

        public int Count => internalList.Count;

        public LinkedQueue () { }

        public LinkedQueue (T[] initialElements) => internalList = new LinkedList<T>(initialElements);

        public bool Contains (T element)
        {
            bool contains = false;
            for (int i = 0; i < internalList.Count; i++)
                if (internalList[i].Equals(element))
                {
                    contains = true;
                    break;
                }
            return contains;
        }

        public void Enqueue (T element) => internalList.Add(element);

        /// <exception cref="System.InvalidOperationException"> Thrown if queue is empty. </exception>
        public T Dequeue ()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            T element = internalList[0];
            internalList.Remove(0);
            return element;
        }

        /// <exception cref="System.InvalidOperationException"> Thrown if queue is empty. </exception>
        public T Peek ()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            return internalList[0];
        }

        public T[] ToArray () => internalList.ToArray();
    }
}