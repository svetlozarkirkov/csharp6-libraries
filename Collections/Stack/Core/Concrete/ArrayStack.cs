namespace Collections.Stack.Core.Concrete
{
    using Collections.Injectors.Clear;
    using Collections.Injectors.Index;
    using Collections.Stack.Core.Base;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    /// <summary>
    /// Default implementation of ArrayStackBase.
    /// </summary>
    /// <typeparam name="T">The type of items in the stack.</typeparam>
    public class ArrayStack<T> : ArrayStackBase<T>, IClearable, IIndexable<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <param name="capacity">The initial capacity.</param>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        public ArrayStack(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than zero.</exception>
        public ArrayStack()
        {
        }

        /// <summary>
        /// Clears all items in the collection.
        /// </summary>
        public void Clear()
        {
            this.Stack = new T[this.InitializedCapacity];
        }

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>T.</returns>
        public T this[int index] => this.Stack[index];
    }
}