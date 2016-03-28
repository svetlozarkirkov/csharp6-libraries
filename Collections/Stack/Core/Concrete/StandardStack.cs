namespace Collections.Stack.Core.Concrete
{
    using System;
    using System.Threading.Tasks;
    using Collections.Stack.Core.Base;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Default implementation of the Stack.
    /// </summary>
    /// <typeparam name="T">The type of items in the stack.</typeparam>
    [Serializable]
    public class StandardStack<T> : StackBase<T>
    {
        /// <summary>
        /// Creates a new stack with a given initial capacity.
        /// </summary>
        /// <param name="capacity">Initial capacity of the stack.</param>
        public StandardStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Creates a new stack with the default capacity.
        /// </summary>
        public StandardStack()
        {
        }

        /// <summary>
        /// Handles the behaviour when the stack has no items.
        /// </summary>
        /// <exception cref="EmptyStackException">Stack is empty.</exception>
        protected override void HandleEmptyStack()
        {
            throw new EmptyStackException("Stack is empty."); // Not L10N
        }

        /// <summary>
        /// Hangles the behaviour when the stack is full.
        /// </summary>
        protected override void HandleFullStack()
        {
            this.ResizeStack();
        }

        /// <summary>
        /// Parallel method for increasing stack capacity.
        /// </summary>
        private void ResizeStack()
        {
            var resizedStack = new T[this._stack.Length * 2];

            Parallel.ForEach(this._stack, (item, state, index)
                => resizedStack[index] = this._stack[index]);

            this._stack = resizedStack;
        }
    }
}