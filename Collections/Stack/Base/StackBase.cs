namespace Collections.Stack.Base
{
    using System;
    using System.Linq;
    using Collections.Stack.Interface;

    /// <summary>
    /// The base abstraction for IStack.
    /// </summary>
    /// <typeparam name="T">Type of the objects contained in the stack.</typeparam>
    public abstract class StackBase<T> : IStack<T>
    {
        /// <summary>
        /// Holds the default size of the underlying array.
        /// </summary>
        protected const int DefaultCapacity = 8;

        /// <summary>
        /// The underlying array.
        /// </summary>
        protected T[] _stack;

        /// <summary>
        /// Each next inserted item will use this position.
        /// </summary>
        protected int _currentPosition;

        /// <summary>
        /// Creates a new instance of the <see cref="StackBase{T}"/> class with given capacity.
        /// </summary>
        /// <param name="capacity">Initial capacity.</param>
        protected StackBase(int capacity)
        {
            this._stack = new T[capacity];
            this._currentPosition = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackBase{T}"/> class with the default capacity.
        /// </summary>
        protected StackBase(): this(DefaultCapacity)
        {
        }

        /// <summary>
        /// Inserts an element at the end of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        public void Push(T item)
        {
            if (this._stack.Length == this._currentPosition)
            {
                this._stack = this.ResizeStack();
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
                throw new IndexOutOfRangeException("Cannot pop from an empty stack.");
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
                throw new IndexOutOfRangeException("Cannot peek into an empty stack.");
            }

            return this._stack[this._currentPosition - 1];
        }

        /// <summary>
        /// Gets the count of elements in the stack (not the capacity of the underlying array).
        /// </summary>
        /// <returns>Count of elements in the stack.</returns>
        public int Size() => this._currentPosition;

        /// <summary>
        /// Returns a string representation of the stack.
        /// </summary>
        /// <returns>String representation of the stack.</returns>
        public override string ToString() => $"[ {string.Join(", ", this._stack.Take(this._currentPosition))} ]";

        /// <summary>
        /// Default method for increasing stack capacity.
        /// </summary>
        protected virtual T[] ResizeStack()
        {
            var updatedStackCapacity = this._stack.Length * 2;
            var updatedStack = new T[updatedStackCapacity];
            Array.Copy(this._stack, updatedStack, this._stack.Length);
            return updatedStack;
        }
    }
}