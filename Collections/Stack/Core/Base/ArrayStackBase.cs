namespace Collections.Stack.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;
    using Collections.Stack.Core.Interface;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Class ArrayStackBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Interface.IStack{T}" />
    public abstract class ArrayStackBase<T> : IStack<T>
    {
        /// <summary>
        /// The default capacity of the Standard Stack.
        /// </summary>
        protected const int DefaultStackCapacity = 8;

        /// <summary>
        /// The capacity with which the stack was initialized.
        /// </summary>
        protected readonly int InitializedCapacity;

        /// <summary>
        /// The underlying array.
        /// </summary>
        protected T[] Stack;

        /// <summary>
        /// The top position of the stack.
        /// </summary>
        protected int TopPosition;

        /// <summary>
        /// Creates a new instance of the <see cref="ArrayStackBase{T}" /> class with the given capacity.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        protected ArrayStackBase(int capacity)
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
        /// Creates a new instance of the <see cref="ArrayStackBase{T}" /> class with the default capacity.
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        protected ArrayStackBase() : this(DefaultStackCapacity)
        {
        }

        /// <summary>
        /// Inserts an element at the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The argument is null.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        public virtual void Push(T item)
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
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        public virtual T Pop()
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
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        public virtual T Peek()
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
        public virtual int Size() => this.TopPosition;

        /// <summary>
        /// Handles the behavior when the stack is empty.
        /// </summary>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        protected virtual void EmptyStackHandler()
        {
            throw new EmptyStackException("The stack is empty."); // Not L10N
        }

        /// <summary>
        /// Handles the behavior when the stack is full.
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The argument is null.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void FullStackHandler()
        {
            this.ResizeStack();
        }

        /// <summary>
        /// Resizes the stack.
        /// </summary>
        /// <exception cref="ArgumentNullException">The argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void ResizeStack()
        {
            var updatedStack = new T[this.Stack.Length * 2];
            Parallel.For(0, this.TopPosition, i => updatedStack[i] = this.Stack[i]);
            this.Stack = updatedStack;
        }
    }
}