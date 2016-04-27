namespace Collections.Stack.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using Collections.Core.Base;
    using Collections.Stack.Core.Contracts;

    /// <summary>
    /// Class ArrayStack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Contracts.IStack{T}" />
    public class ArrayStack<T> : ArrayCollectionBase<T>, IStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public ArrayStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        public ArrayStack()
        {
        }

        /// <summary>
        /// Inserts an element at the top of the stack.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        public virtual void Push(T item)
        {
            Contract.Requires(item != null);

            if (this.CurrentPosition == this.Collection.Length) this.FullCapacityHandler();

            this.Collection[this.CurrentPosition] = item;
            this.CurrentPosition++;
        }

        /// <summary>
        /// Returns and removes the top element in the stack.
        /// </summary>
        /// <returns>The tpp element in the stack.</returns>
        public virtual T Pop()
        {
            if (this.CurrentPosition == 0) this.EmptyCollectionHandler();

            this.CurrentPosition--;
            return this.Collection[this.CurrentPosition];
        }

        /// <summary>
        /// Returns the top element in the stack.
        /// </summary>
        /// <returns>The top element in the stack.</returns>
        public virtual T Peek()
        {
            if (this.CurrentPosition == 0) this.EmptyCollectionHandler();

            return this.Collection[this.CurrentPosition - 1];
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Size
        public override int Size() => this.CurrentPosition;
    }
}