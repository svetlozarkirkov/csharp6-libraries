namespace Collections.Stack.Concrete
{
    using Collections.Stack.Base;

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
        public Stack(int capacity)
            : base(capacity)
        {
        }

        /// <summary>
        /// Creates a new stack with the default capacity (from "DefaultStackBase")
        /// </summary>
        public Stack()
        {
        }
    }
}