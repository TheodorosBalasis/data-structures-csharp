namespace DataStructures.Source
{
    /// <summary> Generic interface for stack implementations. </summary>
    public interface IStack<T>
    {
        int Count
        {
            get;
        }

        void Push (T element);

        /// <exception cref="System.InvalidOperationException"> Thrown if stack is empty. </exception>
        T Pop ();

        /// <exception cref="System.InvalidOperationException"> Thrown if stack is empty. </exception>
        T Peek ();

        bool Contains (T element);

        T[] ToArray ();
    }
}