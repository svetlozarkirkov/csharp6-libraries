namespace Collections.Stack.Core.Interface
{
    using Collections.Core.Interface;

    /// <summary>
    /// The official interface of the Stack sub-class.
    /// Has four basic stack methods.
    /// </summary>
    /// <typeparam name="T">The type which is stored in the stack.</typeparam>
    public interface IStack<T> : ICollection
    {
        /// <summary>
        /// Inserts an item at the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        void Push(T item);

        /// <summary>
        /// Removes the top item in the stack and returns it.
        /// </summary>
        /// <returns>The removed item.</returns>
        T Pop();

        /// <summary>
        /// Returns the top item in the stack without removing it.
        /// </summary>
        /// <returns>The item to be returned.</returns>
        T Peek();

        /// <summary>
        /// Gets the count of elements in the stack.
        /// </summary>
        /// <returns>Count of elements in the stack.</returns>
        int Size();
    }
}