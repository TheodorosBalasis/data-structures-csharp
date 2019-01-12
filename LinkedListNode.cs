namespace DataStructures
{
	public class LinkedListNode<T>
	{
		public T Data { get; set; } = default(T);
		public LinkedListNode<T> PreviousNode { get; set; } = null;
		public LinkedListNode<T> NextNode { get; set; } = null;

		public LinkedListNode (T data)
		{
			Data = data;
		}

		public LinkedListNode (T data, LinkedListNode<T> previousNode, LinkedListNode<T> nextNode)
		{
			Data = data;
			PreviousNode = previousNode;
			NextNode = nextNode;
		}
	}
}