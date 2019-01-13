using System;
using System.Linq;

namespace DataStructures
{
	public class LinkedList<T>
	{
		private LinkedListNode<T> firstNode;
		private LinkedListNode<T> lastNode;

		public T this[int i]
		{
			get
			{
				if (i >= Count)
					throw new IndexOutOfRangeException();
				var node = firstNode;
				for (var j = 0; j <= i; j++)
					node = node.NextNode;
				return node.Data;
			}
			set
			{
				if (i > Count)
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

		public LinkedList ()
		{

		}

		public LinkedList (T[] initialElements)
		{
			if (initialElements.Length == 0)
				return;

			firstNode = new LinkedListNode<T>(initialElements[0]);
            lastNode = firstNode;

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

		}

		public void Remove (int index)
		{

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