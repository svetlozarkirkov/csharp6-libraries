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
        /// </summary>
        /// <param name="capacity"></param>
        public PermanentStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// </summary>
        /// <exception cref="EmptyStackException">Condition.</exception>
        protected override void HandleEmptyStack()
        {
            throw new EmptyStackException("Stack is empty."); // Not L10N
        }

        /// <summary>
        /// </summary>
        /// <exception cref="FullStackException">Condition.</exception>
        protected override void HandleFullStack()
        {
            throw new FullStackException("Stack is full."); // Not L10N
        }
    }
}