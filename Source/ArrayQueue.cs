using System;

namespace DataStructures.Source
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private const int DEFAULT_CHUNK_SIZE = 10;

        private T[] internalArray = new T[DEFAULT_CHUNK_SIZE];
        private readonly int chunkSize = DEFAULT_CHUNK_SIZE;
        private int lastElementIndex = -1;

        public int Count
        {
            get => lastElementIndex + 1;
        }

        public ArrayQueue () { }

        public ArrayQueue (int chunkSize)
        {
            this.chunkSize = chunkSize;
            internalArray = new T[chunkSize];
        }

        public ArrayQueue (T[] initialElements)
        {
            internalArray = new T[initialElements.Length + (initialElements.Length % chunkSize)];
            Array.Copy(initialElements, internalArray, initialElements.Length);
            lastElementIndex = initialElements.Length - 1;
        }

        public ArrayQueue (T[] initialElements, int chunkSize)
        {
            this.chunkSize = chunkSize;
            internalArray = new T[initialElements.Length + (initialElements.Length % chunkSize)];
            Array.Copy(initialElements, internalArray, initialElements.Length);
            lastElementIndex = initialElements.Length - 1;
        }

        public bool Contains (T element)
        {
            var found = false;

            foreach (var arrayElement in internalArray)
            {
                if (arrayElement.Equals(element))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        public void Enqueue (T element)
        {
            if (lastElementIndex == internalArray.Length - 1)
                enlargeInternalArray();

            lastElementIndex++;
            internalArray[lastElementIndex] = element;
        }

        public T Dequeue ()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            var element = internalArray[0];

            for (int i = 1; i < internalArray.Length; i++)
                internalArray[i - 1] = internalArray[i];

            internalArray[Count - 1] = default(T);
            lastElementIndex--;

            if (lastElementIndex == internalArray.Length - chunkSize - 1)
                shrinkInternalArray();

            return element;
        }

        public T Peek ()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            return internalArray[0];
        }

        public T[] ToArray ()
        {
            var arrayCopy = new T[Count];
            Array.Copy(internalArray, arrayCopy, Count);
            return arrayCopy;
        }

        private void enlargeInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length + chunkSize);

        private void shrinkInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length - chunkSize);
    }
}