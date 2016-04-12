namespace Collections.Core.Base
{
    using Collections.Core.ExceptionHandling.Concrete;
    using Collections.Core.Interface;

    /// <summary>
    /// Class ArrayCollectionBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="ICollection" />
    public abstract class ArrayCollectionBase<T> : ICollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayCollectionBase{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        protected ArrayCollectionBase(int capacity)
        {
            if (capacity <= 0)
            {
                throw new InvalidCollectionCapacityException();
            }

            this.Collection = new T[capacity];
            this.InitializedCapacity = capacity;
            this.CurrentPosition = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayCollectionBase{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        protected ArrayCollectionBase() : this(DefaultCapacity)
        {
        }

        /// <summary>
        /// Gets the default capacity.
        /// </summary>
        /// <value>The default capacity.</value>
        protected static int DefaultCapacity => 8;

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>The collection.</value>
        protected T[] Collection { get; set; }

        /// <summary>
        /// Gets the initialized capacity.
        /// </summary>
        /// <value>The initialized capacity.</value>
        protected int InitializedCapacity { get; }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        /// <value>The current position.</value>
        protected int CurrentPosition { get; set; }
    }
}