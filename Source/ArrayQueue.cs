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
			throw new System.NotImplementedException();
		}

		public void Enqueue (T element)
		{
			throw new System.NotImplementedException();
		}

		public T Dequeue ()
		{
			throw new System.NotImplementedException();
		}

		public T Peek ()
		{
			throw new System.NotImplementedException();
		}

		public T[] ToArray ()
		{
			throw new System.NotImplementedException();
		}

		private void enlargeInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length + chunkSize);

		private void shrinkInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length - chunkSize);
	}
}