﻿using System;

namespace DataStructures
{
	public class ArrayStack<T> : IStack<T>
	{
		private const int DEFAULT_CHUNK_SIZE = 10;

		private T[] internalArray;
		private bool chunkAllocation;
		private int chunkSize;
        private int lastElementIndex;

		public ArrayStack () : this(false) { }

		public ArrayStack (bool chunkAllocation) : this(chunkAllocation, DEFAULT_CHUNK_SIZE) { }

		public ArrayStack (bool chunkAllocation, int chunkSize)
		{
            this.chunkAllocation = chunkAllocation;
            this.chunkSize = chunkAllocation ? chunkSize : 1;
            lastElementIndex = 0;

            internalArray = new T[chunkSize];
		}

		public int Count
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public void Push (T element)
		{
			throw new NotImplementedException();
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

        private void enlargeInternalArray()
        {
			throw new NotImplementedException();
        }

        private void shrinkInternalArray()
        {
			throw new NotImplementedException();
        }
	}
}