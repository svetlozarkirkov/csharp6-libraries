namespace Collections.Stack.Core.Base
{
    using System;
    using System.Threading.Tasks;
    using Collections.Stack.Core.Interface;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// StandardStackBase
    /// </summary>
    /// <typeparam name="T">Type of the items contained in the stack.</typeparam>
    /// <seealso cref="Interface.IStandardStack{T}" />
    public abstract class StandardStackBase<T> : StackBase<T>, IStandardStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardStackBase{T}"/> class.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        protected StandardStackBase(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardStackBase{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        protected StandardStackBase()
        {
        }

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
                    "Invalid stack index."); // Not L10N
            }
        }

        /// <summary>
        /// Handles the behaviour when the stack is empty.
        /// </summary>
        /// <exception cref="EmptyStackException">Stack is empty.</exception>
        protected override void EmptyStackHandler()
        {
            throw new EmptyStackException("The stack is empty."); // Not L10N
        }

        /// <summary>
        /// Hangles the behaviour when the stack is full.
        /// </summary>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        protected override void FullStackHandler()
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