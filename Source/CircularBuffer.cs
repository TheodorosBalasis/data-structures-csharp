using System;

namespace DataStructures.Source
{
    public class CircularBuffer<T>
    {
        private T[] internalArray;
        private int readIndex, writeIndex = 0;

        public CircularBuffer (int size) => internalArray = new T[size];


        public CircularBuffer (T[] initialElements)
        {
            internalArray = new T[initialElements.Length];
            Array.Copy(initialElements, internalArray, internalArray.Length);
        }

        public void Write (T element)
        {
            internalArray[writeIndex] = element;
            writeIndex = writeIndex == internalArray.Length - 1 ? 0 : writeIndex + 1;
        }

        public T Read ()
        {
            T element = internalArray[readIndex];
            readIndex = readIndex == internalArray.Length - 1 ? 0 : readIndex + 1;
            return element;
        }

        public T[] ToArray ()
        {
            T[] array = new T[internalArray.Length];
            Array.Copy(internalArray, array, array.Length);
            return array;
        }
    }
}