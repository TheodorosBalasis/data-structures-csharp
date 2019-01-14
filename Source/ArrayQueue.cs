

namespace DataStructures.Source
{
	public class ArrayQueue<T> : IQueue<T>
	{
        private const int DEFAULT_CHUNK_SIZE = 10;

        private T[] internalArray = new T[DEFAULT_CHUNK_SIZE];
        private readonly int chunkSize = DEFAULT_CHUNK_SIZE;
        private int lastElementIndex = -1;

		public int Count => throw new System.NotImplementedException();

        public ArrayQueue() { }

        public ArrayQueue(int chunkSize)
        {

        }

        public ArrayQueue(T[] initialElements)
        {

        }

        public ArrayQueue(T[] initialElements, int chunkSize)
        {

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
	}
}