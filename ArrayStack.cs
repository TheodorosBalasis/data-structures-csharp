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

		/// <exception cref="System.ArgumentNullException"> Thrown if initialElements is null </exception>
		public ArrayStack (T[] initialElements) : this(initialElements, false) { }

		/// <exception cref="System.ArgumentNullException"> Thrown if initialElements is null </exception>
		public ArrayStack (T[] initialElements, bool chunkAllocation) :
			this(initialElements, chunkAllocation, DEFAULT_CHUNK_SIZE) { }

		/// <exception cref="System.ArgumentNullException"> Thrown if initialElements is null </exception>
		public ArrayStack (T[] initialElements, bool chunkAllocation, int chunkSize)
		{
			if (initialElements == null)
				throw new ArgumentNullException("Initial stack elements array is null!");

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

		/// <exception cref="System.InvalidOperationException"> Thrown if stack is empty. </exception>
		public T Pop ()
		{
			if (Count == 0)
				throw new InvalidOperationException("Stack is empty!");

			T element = internalArray[lastElementIndex];
			internalArray[lastElementIndex] = default(T);
			lastElementIndex--;

			if (internalArray.Length - Count >= chunkSize)
				shrinkInternalArray();

			return element;
		}

		/// <exception cref="System.InvalidOperationException"> Thrown if stack is empty. </exception>
		public T Peek ()
		{
			if (Count == 0)
				throw new InvalidOperationException("Stack is empty!");

			return internalArray[lastElementIndex];
		}

		public bool Contains (T element) => Array.Exists(internalArray, arrayElement => arrayElement.Equals(element));

		public T[] ToArray ()
		{
			T[] array = new T[Count];
			Array.Copy(internalArray, array, array.Length);
			return array;
		}

		private void enlargeInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length + chunkSize);

		private void shrinkInternalArray () => Array.Resize<T>(ref internalArray, internalArray.Length - chunkSize);
	}
}
