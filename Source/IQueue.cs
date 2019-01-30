namespace DataStructures.Source
{
    public interface IQueue<T>
    {
        int Count
        {
            get;
        }

        void Enqueue (T element);

        /// <exception cref="System.InvalidOperationException"> Thrown if queue is empty. </exception>
        T Dequeue ();

        /// <exception cref="System.InvalidOperationException"> Thrown if queue is empty. </exception>
        T Peek ();

        bool Contains (T element);

        T[] ToArray ();
    }
}