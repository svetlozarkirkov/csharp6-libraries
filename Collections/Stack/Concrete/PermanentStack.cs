namespace Collections.Stack.Concrete
{
    using Collections.Stack.Base;
    using Collections.Stack.Exceptions;

    /// <summary>
    /// Non-resizable stack.
    /// </summary>
    /// <typeparam name="T">Type of the items in the stack.</typeparam>
    //[Serializable]
    public class PermanentStack<T> : StackBase<T>
    {
        /// <summary>
        /// Creates a stack with permanent capacity.
        /// </summary>
        /// <param name="capacity">Capacity size.</param>
        public PermanentStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Handles the behaviour when the stack has no items.
        /// </summary>
        /// <exception cref="EmptyStackException">Condition.</exception>
        protected override void HandleEmptyStack()
        {
            throw new EmptyStackException("Stack is empty."); // Not L10N
        }

        /// <summary>
        /// Handles the behaviour when the stack is full.
        /// </summary>
        /// <exception cref="FullStackException">Condition.</exception>
        protected override void HandleFullStack()
        {
            throw new FullStackException("Stack is full."); // Not L10N
        }
    }
}