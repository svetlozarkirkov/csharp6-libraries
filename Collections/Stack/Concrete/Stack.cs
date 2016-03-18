namespace Collections.Stack.Concrete
{
    using System.Threading.Tasks;
    using Collections.Stack.Base;
    using Collections.Stack.Exceptions;

    /// <summary>
    /// Default implementation of the default base stack.
    /// </summary>
    /// <typeparam name="T">The type of objects in the stack.</typeparam>
    public class Stack<T> : StackBase<T>
    {
        /// <summary>
        /// Creates a new stack with a given initial capacity.
        /// </summary>
        /// <param name="capacity">Initial capacity of the stack.</param>
        public Stack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Creates a new stack with the default capacity (from "DefaultStackBase")
        /// </summary>
        public Stack()
        {
        }

        /// <summary>
        /// </summary>
        /// <exception cref="EmptyStackException">Stack is empty.</exception>
        protected override void HandleEmptyStack()
        {
            throw new EmptyStackException("Stack is empty."); // Not L10N
        }

        /// <summary>
        /// </summary>
        protected override void HandleFullStack()
        {
            this.ResizeStack();
        }

        /// <summary>
        /// Multicore method for increasing stack capacity.
        /// </summary>
        private T[] ResizeStack()
        {
            var updatedStackCapacity = this._stack.Length * 2;
            var updatedStack = new T[updatedStackCapacity];
            Parallel.ForEach(this._stack, (item, state, index) => updatedStack[index] = this._stack[index]);
            return updatedStack;
        }
    }
}