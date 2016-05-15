namespace ML.Stack.Core.Contracts
{
    /// <summary>
    /// The default contract for a stack. Holds the four basic operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Adds the specified item on the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        void Push(T item);

        /// <summary>
        /// Returns the top item and removes it from the stack.
        /// </summary>
        /// <returns>The top item in stack.</returns>
        T Pop();

        /// <summary>
        /// Returns the top item in the stack.
        /// </summary>
        /// <returns>The top item in the stack.</returns>
        T Peek();

        /// <summary>
        /// Returns the count of items in the stack.
        /// </summary>
        /// <returns>The count of items in the stack.</returns>
        int Size();
    }
}