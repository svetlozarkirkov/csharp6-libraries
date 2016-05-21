namespace ML.Stack.Core.Base
{
    using System;
    using System.Threading.Tasks;
    using ML.Stack.Core.Contracts;
    using ML.Stack.Core.Exceptions;

    /// <summary>
    /// Base stack implementation using an array to hold its items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Contracts.IStack{T}" />
    public abstract class ArrayStackBase<T> : IStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStackBase{T}" /> class.
        /// </summary>
        /// <param name="stackCapacity">The initial stack capacity.</param>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        protected ArrayStackBase(int stackCapacity)
        {
            if (stackCapacity <= 0)
            {
                throw new InvalidStackCapacityException(
                    nameof(stackCapacity),
                    stackCapacity,
                    "Stack capacity must be greater than zero.");
            }

            this.Stack = new T[stackCapacity];
            this.InitializedStackCapacity = stackCapacity;
            this.NextPosition = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStackBase{T}" /> class.
        /// </summary>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
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
        protected T[] Stack { get; set; }

        /// <summary>
        /// Gets or sets the index which will be used to insert an element in the stack.
        /// </summary>
        /// <value>The top position of the stack.</value>
        protected int NextPosition { get; set; }

        /// <summary>
        /// Gets the capacity with which the stack was initialized.
        /// </summary>
        /// <value>The initialized stack capacity.</value>
        protected int InitializedStackCapacity { get; }

        /// <summary>
        /// Adds the specified item on the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        public void Push(T item)
        {
            if (this.NextPosition == this.Stack.Length)
            {
                this.FullStackHandler();
            }

            this.Stack[this.NextPosition] = item;
            this.NextPosition++;
        }

        /// <summary>
        /// Returns the top item and removes it from the stack.
        /// </summary>
        /// <returns>The top item in stack.</returns>
        /// <exception cref="EmptyStackException">Cannot pop from an empty stack.</exception>
        public T Pop()
        {
            if (this.NextPosition == 0)
            {
                throw new EmptyStackException("Cannot pop from an empty stack.");
            }

            this.NextPosition--;
            return this.Stack[this.NextPosition];
        }

        /// <summary>
        /// Returns the top item in the stack.
        /// </summary>
        /// <returns>The top item in the stack.</returns>
        /// <exception cref="EmptyStackException">Cannot peek into an empty stack.</exception>
        public T Peek()
        {
            if (this.NextPosition == 0)
            {
                throw new EmptyStackException("Cannot peek into an empty stack.");
            }

            return this.Stack[this.NextPosition - 1];
        }

        /// <summary>
        /// Returns the count of items in the stack.
        /// </summary>
        /// <returns>The count of items in the stack.</returns>
        public int Size() => this.NextPosition;

        /// <summary>
        /// Handles the behaviour when the stack is at full capacity.
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void FullStackHandler()
        {
            this.ResizeStack();
        }

        /// <summary>
        /// Resizes the stack.
        /// </summary>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void ResizeStack()
        {
            var resizedStack = new T[this.Stack.Length * 2];
            Parallel.For(0, this.Stack.Length, i => { resizedStack[i] = this.Stack[i]; });
            this.Stack = resizedStack;
        }
    }
}