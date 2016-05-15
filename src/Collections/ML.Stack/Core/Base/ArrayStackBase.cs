namespace ML.Stack.Core.Base
{
    using ML.Stack.Core.Contracts;

    /// <summary>
    /// Base stack implementation using an array to hold its items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Contracts.IStack{T}" />
    public abstract class ArrayStackBase<T> : IStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStackBase{T}"/> class.
        /// </summary>
        /// <param name="stackCapacity">The stack capacity.</param>
        protected ArrayStackBase(int stackCapacity)
        {
            this.Stack = new T[stackCapacity];
            this.InitializedStackCapacity = stackCapacity;
            this.CurrentPosition = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStackBase{T}"/> class.
        /// </summary>
        protected ArrayStackBase() : this(DefaultStackCapacity) { }

        /// <summary>
        /// Gets the default stack capacity.
        /// </summary>
        /// <value>The default stack capacity.</value>
        protected static int DefaultStackCapacity => 16;

        /// <summary>
        /// Gets or sets the stack.
        /// </summary>
        /// <value>The stack.</value>
        /// TODO Edit XML Comment Template for Stack
        protected T[] Stack { get; set; }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        /// <value>The current position.</value>
        /// TODO Edit XML Comment Template for CurrentPosition
        protected int CurrentPosition { get; set; }

        /// <summary>
        /// Gets the initialized stack capacity.
        /// </summary>
        /// <value>The initialized stack capacity.</value>
        /// TODO Edit XML Comment Template for InitializedStackCapacity
        protected int InitializedStackCapacity { get; }

        /// <summary>
        /// Adds the specified item on the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Push(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns the top item and removes it from the stack.
        /// </summary>
        /// <returns>The top item in stack.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T Pop()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns the top item in the stack.
        /// </summary>
        /// <returns>The top item in the stack.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T Peek()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns the count of items in the stack.
        /// </summary>
        /// <returns>The count of items in the stack.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int Size()
        {
            throw new System.NotImplementedException();
        }
    }
}