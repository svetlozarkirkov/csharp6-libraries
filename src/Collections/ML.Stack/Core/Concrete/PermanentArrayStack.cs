namespace ML.Stack.Core.Concrete
{
    using ML.Stack.Core.Base;
    using ML.Stack.Core.Exceptions;

    /// <summary>
    /// Stack with permanent capacity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Base.ArrayStackBase{T}" />
    public class PermanentArrayStack<T> : ArrayStackBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentArrayStack{T}"/> class.
        /// </summary>
        /// <param name="stackCapacity">The initial stack capacity.</param>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        protected PermanentArrayStack(int stackCapacity) : base(stackCapacity)
        {
        }

        /// <summary>
        /// Handles the behaviour when the stack is at full capacity.
        /// </summary>
        /// <exception cref="FullStackException">Cannot exceed the capacity of a permanent stack.</exception>
        protected override void FullStackHandler()
        {
            throw new FullStackException("Cannot exceed the capacity of a permanent stack.");
        }
    }
}