namespace ML.Stack.Core.Concrete
{
    using ML.Stack.Core.Base;
    using ML.Stack.Core.Exceptions;

    /// <summary>
    /// Class ArrayStack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Base.ArrayStackBase{T}" />
    public class ArrayStack<T> : ArrayStackBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        public ArrayStack()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <param name="stackCapacity">The initial stack capacity.</param>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        public ArrayStack(int stackCapacity) : base(stackCapacity)
        {
        }
    }
}