namespace Collections.Stack.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using Collections.Stack.Core.Interface;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// StandardStackBase
    /// </summary>
    /// <typeparam name="T">Type of the items contained in the stack.</typeparam>
    /// <seealso cref="Collections.Stack.Core.Interface.IStandardStack{T}" />
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
        protected int CurrentPosition;

        /// <summary>
        /// The capacity with which the stack was initialized.
        /// </summary>
        private readonly int _initializedCapacity;

        /// <summary>
        /// Creates a new instance of the <see cref="StandardStackBase{T}" /> class with the given capacity.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="Collections.Stack.ExceptionHandling.Core.Concrete.InvalidStackCapacityGivenException">Invalid capacity assigned to the stack.</exception>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        protected StandardStackBase(int capacity)
        {
            if (capacity < 0)
            {
                throw new InvalidStackCapacityGivenException(
                    nameof(capacity),
                    capacity,
                    "Invalid capacity assigned to the stack."); // Not L10N
            }

            this.Stack = new T[capacity];
            this._initializedCapacity = capacity;
            this.CurrentPosition = 0;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StandardStackBase{T}" /> class with the default capacity.
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        protected StandardStackBase() : this(DefaultStackCapacity)
        {
        }

        /// <summary>
        /// Inserts an element at the end of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        public void Push(T item)
        {
            Contract.Requires(item != null);

            if (this.CurrentPosition == this.Stack.Length)
            {
                this.HandleFullStack();
            }

            this.Stack[this.CurrentPosition] = item;
            this.CurrentPosition++;
        }

        /// <summary>
        /// Returns the last element and removes it from the stack.
        /// </summary>
        /// <returns>The last element in the stack.</returns>
        public T Pop()
        {
            if (this.CurrentPosition == 0)
            {
                this.HandleEmptyStack();
            }

            var poppedItem = this.Stack[--this.CurrentPosition];
            this.Stack[this.CurrentPosition] = default(T);
            return poppedItem;
        }

        /// <summary>
        /// Returns the last element from the stack (without removing it).
        /// </summary>
        /// <returns>The last element in the stack.</returns>
        public T Peek()
        {
            if (this.CurrentPosition == 0)
            {
                this.HandleEmptyStack();
            }

            return this.Stack[this.CurrentPosition - 1];
        }

        /// <summary>
        /// Gets the count of elements in the stack (not the capacity of the underlying array).
        /// </summary>
        /// <returns>Count of elements in the stack.</returns>
        public int Size() => this.CurrentPosition;

        /// <summary>
        /// Reinitializes the underlying array.
        /// </summary>
        public void Clear()
        {
            this.Stack = new T[this._initializedCapacity];
            this.CurrentPosition = 0;
        }

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The item with the specified index.</returns>
        /// <exception cref="Collections.Stack.ExceptionHandling.Core.Concrete.StackIndexOutOfRangeException">There is no such index in the stack.</exception>
        /// <exception cref="StackIndexOutOfRangeException">There is no such index in the stack.</exception>
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.CurrentPosition)
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
        /// Handles the behaviour when the stack has no items.
        /// </summary>
        protected abstract void HandleEmptyStack();

        /// <summary>
        /// Handles the behaviour when the stack is full.
        /// </summary>
        protected abstract void HandleFullStack();
    }
}