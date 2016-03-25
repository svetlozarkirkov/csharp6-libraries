namespace Collections.Stack.Core.Interface
{
    /// <summary>
    /// The official interface of the Stack sub-class.
    /// Has the four basic stack operations.
    /// </summary>
    /// <typeparam name="T">Type to be stored in the stack.</typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Inserts an item at the end of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        void Push(T item);

        /// <summary>
        /// Removes the last item in the stack and returns it.
        /// </summary>
        /// <returns>The removed item.</returns>
        T Pop();

        /// <summary>
        /// Returns the last item in the stack without removing it.
        /// </summary>
        /// <returns>The item to be returned.</returns>
        T Peek();

        /// <summary>
        /// Gets the count of elements in the stack (not the total capacity).
        /// </summary>
        /// <returns>Count of elements in the stack.</returns>
        int Size();
    }
}