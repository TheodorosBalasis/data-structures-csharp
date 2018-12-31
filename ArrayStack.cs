using System;

namespace DataStructures
{
	public class ArrayStack<T> : IStack<T>
	{
		private const int DEFAULT_CHUNK_SIZE = 10;

		private T[] internalArray;
		private readonly bool chunkAllocation;
		private readonly int chunkSize;
		private int lastElementIndex;

		public ArrayStack () : this(false) { }

		public ArrayStack (bool chunkAllocation) : this(chunkAllocation, DEFAULT_CHUNK_SIZE) { }

		public ArrayStack (bool chunkAllocation, int chunkSize)
		{
			this.chunkAllocation = chunkAllocation;
			this.chunkSize = chunkAllocation ? chunkSize : 1;
			lastElementIndex = -1;

			internalArray = new T[chunkSize];
		}

		public ArrayStack (T[] initialElements) : this(initialElements, false) { }

		public ArrayStack (T[] initialElements, bool chunkAllocation) :
			this(initialElements, chunkAllocation, DEFAULT_CHUNK_SIZE) { }

		public ArrayStack (T[] initialElements, bool chunkAllocation, int chunkSize)
		{
			this.chunkAllocation = chunkAllocation;
			this.chunkSize = chunkAllocation ? chunkSize : 1;
			lastElementIndex = initialElements.Length - 1;

			int arraySize = initialElements.Length / chunkSize + (initialElements.Length % chunkSize * chunkSize);
			internalArray = new T[arraySize];
			Array.Copy(initialElements, internalArray, initialElements.Length);
		}

		public int Count
		{
			get => lastElementIndex + 1;
		}

		public void Push (T element)
		{
			if (lastElementIndex == (internalArray.Length - 1))
				enlargeInternalArray();

			lastElementIndex++;
			internalArray[lastElementIndex] = element;
		}

		public T Pop ()
		{
			throw new NotImplementedException();
		}

		public T Peek ()
		{
			throw new NotImplementedException();
		}

		public bool Contains (T element)
		{
			throw new NotImplementedException();
		}

		public T[] ToArray ()
		{
			throw new NotImplementedException();
		}

		private void enlargeInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length + chunkSize);

		private void shrinkInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length - chunkSize);
	}
}
