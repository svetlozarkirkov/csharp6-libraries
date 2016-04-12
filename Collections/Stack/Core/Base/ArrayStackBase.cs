namespace Collections.Stack.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;
    using Collections.Core.Base;
    using Collections.Core.ExceptionHandling.Concrete;
    using Collections.Stack.Core.Interface;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Class ArrayStackBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Interface.IStack{T}" />
    public abstract class ArrayStackBase<T> : ArrayCollectionBase<T>, IStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStackBase{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        protected ArrayStackBase(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStackBase{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        protected ArrayStackBase()
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

            if (this.CurrentPosition == this.Collection.Length) this.FullStackHandler();

            this.Collection[this.CurrentPosition] = item;
            this.CurrentPosition++;
        }

        /// <summary>
        /// Returns and removes the top element in the stack.
        /// </summary>
        /// <returns>The tpp element in the stack.</returns>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        public virtual T Pop()
        {
            if (this.CurrentPosition == 0) this.EmptyStackHandler();

            this.CurrentPosition--;
            return this.Collection[this.CurrentPosition];
        }

        /// <summary>
        /// Returns the top element in the stack.
        /// </summary>
        /// <returns>The top element in the stack.</returns>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        public virtual T Peek()
        {
            if (this.CurrentPosition == 0) this.EmptyStackHandler();

            return this.Collection[this.CurrentPosition - 1];
        }

        /// <summary>
        /// Gets the count of elements in the stack.
        /// </summary>
        /// <returns>The count of elements in the stack.</returns>
        public virtual int Size() => this.CurrentPosition;

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
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void FullStackHandler()
        {
            this.ResizeStack(2);
        }

        /// <summary>
        /// Resizes the stack.
        /// </summary>
        /// <param name="multiplier">The current capacity will be multiplied by this.</param>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void ResizeStack(int multiplier)
        {
            var updatedStack = new T[this.Collection.Length * multiplier];
            Parallel.For(0, this.CurrentPosition, i => updatedStack[i] = this.Collection[i]);
            this.Collection = updatedStack;
        }
    }
}