namespace Collections.Stack.Core.Concrete
{
    using Collections.Stack.Core.Base;
    using Collections.Stack.Exceptions;

    /// <summary>
    /// Stack with permanent capacity.
    /// </summary>
    /// <typeparam name="T">Type of the items in the stack.</typeparam>
    /// <seealso cref="Base.ArrayStack{T}" />
    public class PermanentArrayStack<T> : ArrayStack<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentArrayStack{T}" /> class.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        public PermanentArrayStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Handles the behaviour when the stack is full.
        /// </summary>
        /// <exception cref="FullStackException">If the stack is full.</exception>
        protected override void FullCapacityHandler()
        {
            throw new FullStackException("Permanent stack cannot exceed its capacity.");
        }
    }
}