namespace Collections.Stack.Core.Concrete
{
    using Collections.Stack.Core.Base;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Stack with permanent capacity.
    /// </summary>
    /// <typeparam name="T">Type of the items in the stack.</typeparam>
    public class PermanentArrayStack<T> : ArrayStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentArrayStack{T}"/> class.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        public PermanentArrayStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Handles the behaviour when the stack is full.
        /// </summary>
        /// <exception cref="FullStackException">Condition.</exception>
        protected override void FullStackHandler()
        {
            throw new FullStackException("The stack is full."); // Not L10N
        }
    }
}