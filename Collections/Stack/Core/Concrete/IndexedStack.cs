namespace Collections.Stack.Core.Concrete
{
    using Collections.Injectors.Indexer;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Class IndexedStack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Stack.Core.Concrete.Stack{T}" />
    /// <seealso cref="Collections.Injectors.Indexer.IIndexable{T}" />
    public class IndexedStack<T> : Stack<T>, IIndexable<T>
    {
        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>T.</returns>
        /// <exception cref="StackIndexOutOfRangeException" accessor="get">Condition.</exception>
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this._currentPosition)
                {
                    return this._stack[index];
                }
                throw new StackIndexOutOfRangeException(
                    nameof(index),
                    index,
                    "There is no such index in the stack."); // Not L10N
            }
        }
    }
}