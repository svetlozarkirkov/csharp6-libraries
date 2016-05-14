namespace Stack.Core.Contracts
{
    /// <summary>
    /// Interface IStack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// TODO Edit XML Comment Template for IStack
    public interface IStack<T>
    {
        /// <summary>
        /// Pushes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// TODO Edit XML Comment Template for Push
        void Push(T item);

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns>T.</returns>
        /// TODO Edit XML Comment Template for Pop
        T Pop();

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>T.</returns>
        /// TODO Edit XML Comment Template for Peek
        T Peek();

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Size
        int Size();
    }
}