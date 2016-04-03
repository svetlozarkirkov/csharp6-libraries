namespace Collections.Stack.Core.Base
{
    using System.Diagnostics.Contracts;
    using Collections.Stack.Core.Interface;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Class StackBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Interface.IStack{T}" />
    public abstract class StackBase<T> : IStack<T>
    {
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
        /// The default capacity of the Standard Stack.
        /// </summary>
        protected const int DefaultStackCapacity = 8;

        /// <summary>
        /// Creates a new instance of the <see cref="StackBase{T}" /> class with the given capacity.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        protected StackBase(int capacity)
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
        /// Creates a new instance of the <see cref="StackBase{T}" /> class with the default capacity.
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        protected StackBase() : this(DefaultStackCapacity)
        {
        }

        /// <summary>
        /// Inserts an element at the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
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
        /// Handles the behavior when the stack is empty.
        /// </summary>
        protected abstract void EmptyStackHandler();

        /// <summary>
        /// Handles the behavior when the stack is full.
        /// </summary>
        protected abstract void FullStackHandler();
    }
}