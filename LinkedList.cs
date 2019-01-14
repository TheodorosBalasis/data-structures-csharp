using System;
using System.Linq;

namespace DataStructures
{
	public class LinkedList<T>
	{
		private LinkedListNode<T> firstNode { get; set; } = null;

		public T this[int i]
		{
			get
			{
				if (i >= Count || i < 0)
					throw new IndexOutOfRangeException();

				var node = firstNode;

				if (i <= Count / 2)
					for (var j = 0; j <= i; j++)
						node = node.NextNode;
				else
					for (var j = Count - 1; j >= i; j--)
						node = node.PreviousNode;

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
			var lastNode = firstNode;

			for (var node = lastNode; node != null; node = node.NextNode)
				lastNode = node;

			newNode.PreviousNode = lastNode;
			lastNode.NextNode = newNode;
		}

		public void Insert (T element, int index)
		{
			
		}

		public void Remove (int index)
		{
			if (index < 0 || index >= Count)
				throw new IndexOutOfRangeException();

			var node = firstNode;

			for (int i = 0; i <= index; i++)
				node = node.NextNode;

			if (index < Count - 1)
				node.PreviousNode.NextNode = node.NextNode;
			if (index > 0)
				node.NextNode.PreviousNode = node.PreviousNode;
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