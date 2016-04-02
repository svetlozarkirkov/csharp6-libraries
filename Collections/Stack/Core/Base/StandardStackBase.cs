namespace Collections.Stack.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;
    using Collections.Stack.Core.Interface;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// StandardStackBase
    /// </summary>
    /// <typeparam name="T">Type of the items contained in the stack.</typeparam>
    /// <seealso cref="Interface.IStandardStack{T}" />
    [Serializable]
    public abstract class StandardStackBase<T> : IStandardStack<T>
    {
        /// <summary>
        /// The default capacity of the Standard Stack.
        /// </summary>
        protected const int DefaultStackCapacity = 8;

        /// <summary>
        /// The underlying array.
        /// </summary>
        protected T[] Stack;

        /// <summary>
        /// The top position of the stack.
        /// </summary>
        protected int TopPosition;

        /// <summary>
        /// The capacity with which the stack was initialized.
        /// </summary>
        protected readonly int InitializedCapacity;

        /// <summary>
        /// Creates a new instance of the <see cref="StandardStackBase{T}" /> class with the given capacity.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        protected StandardStackBase(int capacity)
        {
            if (capacity <= 0)
            {
                throw new InvalidStackCapacityGivenException(
                    nameof(capacity),
                    capacity,
                    "Invalid capacity assigned to the stack."); // Not L10N
            }

            this.Stack = new T[capacity];
            this.InitializedCapacity = capacity;
            this.TopPosition = 0;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StandardStackBase{T}" /> class with the default capacity.
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        protected StandardStackBase() : this(DefaultStackCapacity)
        {
        }

        /// <summary>
        /// Inserts an element at the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public void Push(T item)
        {
            Contract.Requires(item != null);

            if (this.TopPosition == this.Stack.Length)
            {
                this.FullStackHandler();
            }

            this.Stack[this.TopPosition] = item;
            this.TopPosition++;
        }

        /// <summary>
        /// Returns and removes the top element in the stack.
        /// </summary>
        /// <returns>The tpp element in the stack.</returns>
        /// <exception cref="EmptyStackException">Stack is empty.</exception>
        public T Pop()
        {
            if (this.TopPosition == 0)
            {
                this.EmptyStackHandler();
            }

            this.TopPosition--;
            return this.Stack[this.TopPosition];
        }

        /// <summary>
        /// Returns the top element in the stack.
        /// </summary>
        /// <returns>The top element in the stack.</returns>
        /// <exception cref="EmptyStackException">Stack is empty.</exception>
        public T Peek()
        {
            if (this.TopPosition == 0)
            {
                this.EmptyStackHandler();
            }

            return this.Stack[this.TopPosition - 1];
        }

        /// <summary>
        /// Gets the count of elements in the stack.
        /// </summary>
        /// <returns>The count of elements in the stack.</returns>
        public int Size() => this.TopPosition;

        /// <summary>
        /// Clears the stack.
        /// </summary>
        public void Clear()
        {
            this.Stack = new T[this.InitializedCapacity];
            this.TopPosition = 0;
        }

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The item with the specified index.</returns>
        /// <exception cref="StackIndexOutOfRangeException">There is no such index in the stack.</exception>
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.TopPosition)
                {
                    return this.Stack[index];
                }

                throw new StackIndexOutOfRangeException(
                    nameof(index),
                    index,
                    "There is no such index in the stack."); // Not L10N
            }
        }

        /// <summary>
        /// Handles the behaviour when the stack is empty.
        /// </summary>
        /// <exception cref="EmptyStackException">Stack is empty.</exception>
        protected virtual void EmptyStackHandler()
        {
            throw new EmptyStackException("Stack is empty."); // Not L10N
        }

        /// <summary>
        /// Hangles the behaviour when the stack is full.
        /// </summary>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        protected virtual void FullStackHandler()
        {
            this.ResizeStack();
        }

        /// <summary>
        /// Parallel method for increasing stack capacity.
        /// </summary>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        protected virtual void ResizeStack()
        {
            var resizedStack = new T[this.Stack.Length * 2];

            Parallel.ForEach(this.Stack, (item, state, index)
                => resizedStack[index] = this.Stack[index]);

            this.Stack = resizedStack;
        }
    }
}