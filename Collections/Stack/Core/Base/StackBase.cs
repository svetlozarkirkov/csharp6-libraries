namespace Collections.Stack.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using Collections.Stack.Core.Interface;

    /// <summary>
    /// The base abstraction for IStack.
    /// </summary>
    /// <typeparam name="T">Type of the items contained in the stack.</typeparam>
    //[Serializable]
    public abstract class StackBase<T> : IStack<T>
    {
        /// <summary>
        /// Default capacity of a Stack.
        /// </summary>
        protected const int DefaultStackCapacity = 8;

        /// <summary>
        /// The underlying array.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        protected T[] _stack;

        /// <summary>
        /// Each next inserted item will use this position.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        protected int _currentPosition;

        /// <summary>
        /// Creates a new instance of the <see cref="StackBase{T}"/> class with the given capacity.
        /// </summary>
        /// <param name="capacity">Initial capacity.</param>
        protected StackBase(int capacity)
        {
            this._stack = new T[capacity];
            this._currentPosition = 0;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StackBase{T}"/> class with the default capacity.
        /// </summary>
        protected StackBase() : this(DefaultStackCapacity)
        {
        }

        /// <summary>
        /// Inserts an element at the end of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        public void Push(T item)
        {
            Contract.Requires(item != null);

            if (this._currentPosition == this._stack.Length)
            {
                this.HandleFullStack();
            }

            this._stack[this._currentPosition] = item;
            this._currentPosition++;
        }

        /// <summary>
        /// Returns the last element and removes it from the stack.
        /// </summary>
        /// <returns>The last element in the stack.</returns>
        public T Pop()
        {
            if (this._currentPosition == 0)
            {
                this.HandleEmptyStack();
            }

            var poppedItem = this._stack[--this._currentPosition];
            this._stack[this._currentPosition] = default(T);
            return poppedItem;
        }

        /// <summary>
        /// Returns the last element from the stack (without removing it).
        /// </summary>
        /// <returns>The last element in the stack.</returns>
        public T Peek()
        {
            if (this._currentPosition == 0)
            {
                this.HandleEmptyStack();
            }

            return this._stack[this._currentPosition - 1];
        }

        /// <summary>
        /// Gets the count of elements in the stack (not the capacity of the underlying array).
        /// </summary>
        /// <returns>Count of elements in the stack.</returns>
        public int Size() => this._currentPosition;

        /// <summary>
        /// Handles the behaviour when the stack has no items.
        /// </summary>
        protected abstract void HandleEmptyStack();

        /// <summary>
        /// Handles the behaviour when the stack is full.
        /// </summary>
        protected abstract void HandleFullStack();

        /// <summary>
        /// Returns a string representation of the stack.
        /// </summary>
        /// <returns>String representation of the stack.</returns>
        /// <exception cref="ArgumentNullException">Stack is null.</exception>
        public override string ToString() => $"[ {string.Join(", ", this._stack.Take(this._currentPosition))} ]";
    }
}