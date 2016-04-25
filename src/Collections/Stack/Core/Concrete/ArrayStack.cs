namespace Collections.Stack.Core.Concrete
{
    using Collections.Stack.Core.Base;

    /// <summary>
    /// Default implementation of ArrayStackBase.
    /// </summary>
    /// <typeparam name="T">The type of items in the stack.</typeparam>
    public class ArrayStack<T> : ArrayStackBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        public ArrayStack()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        public ArrayStack(int capacity) : base(capacity)
        {
        }
    }
}