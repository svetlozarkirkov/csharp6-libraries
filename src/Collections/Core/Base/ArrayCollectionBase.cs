namespace Collections.Core.Base
{
    using System;
    using System.Threading.Tasks;
    using Collections.Core.Contracts;
    using Collections.Core.Exceptions;
    using Collections.Injectors.Clear;

    /// <summary>
    /// Class ArrayCollectionBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Contracts.ICollection{T}" />
    /// <seealso cref="IClearable" />
    /// TODO Edit XML Comment Template for ArrayCollectionBase
    public abstract class ArrayCollectionBase<T> : ICollection<T>, IClearable
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
                throw new InvalidCollectionCapacityException(
                    nameof(capacity),
                    capacity,
                    "Invalid capacity supplied.");
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
        protected static int DefaultCapacity => 16;

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
        /// Gets or sets the current position (index).
        /// </summary>
        /// <value>The current position.</value>
        protected int CurrentPosition { get; set; }

        /// <summary>
        /// Gets the size of the collection.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public abstract int Size();

        /// <summary>
        /// Clears all items in the collection.
        /// </summary>
        public void Clear()
        {
            this.Collection = new T[this.InitializedCapacity];
        }

        /// <summary>
        /// Handles the behaviour when the collection is empty.
        /// </summary>
        /// <exception cref="EmptyCollectionException">The collection is empty.</exception>
        protected virtual void EmptyCollectionHandler()
        {
            throw new EmptyCollectionException("The collection is empty.");
        }

        /// <summary>
        /// Handles the behaviour when the collection's max capacity is reached.
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void FullCapacityHandler()
        {
            this.ResizeCollection(2);
        }

        /// <summary>
        /// Resizes the collection.
        /// </summary>
        /// <param name="multiplier">The multiplier.</param>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void ResizeCollection(int multiplier)
        {
            var updatedCollection = new T[this.Collection.Length * multiplier];

            Parallel.For(0, this.CurrentPosition,
                i =>
                    {
                        updatedCollection[i] = this.Collection[i];
                    });

            this.Collection = updatedCollection;
        }
    }
}