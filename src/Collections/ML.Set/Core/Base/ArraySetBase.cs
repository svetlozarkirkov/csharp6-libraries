namespace ML.Set.Core.Base
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ML.Set.Core.Contracts;
    using ML.Set.Core.Exceptions;

    /// <summary>
    /// Base set implementation using an array to hold its items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Contracts.ISet{T}" />
    public abstract class ArraySetBase<T> : ISet<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySetBase{T}"/> class.
        /// </summary>
        /// <param name="capacity">The set capacity.</param>
        /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
        protected ArraySetBase(int capacity)
        {
            if (capacity <= 0)
            {
                throw new InvalidSetCapacityException(
                    nameof(capacity),
                    capacity,
                    "Set capacity must be greater than zero.");
            }

            this.Set = new T[capacity];
            this.LastPosition = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySetBase{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
        protected ArraySetBase() : this(DefaultSetCapacity) { }

        /// <summary>
        /// Gets the default set capacity.
        /// </summary>
        /// <value>The default set capacity.</value>
        protected static int DefaultSetCapacity => 16;

        /// <summary>
        /// Gets or sets the set.
        /// </summary>
        /// <value>The set.</value>
        protected T[] Set { get; set; }

        /// <summary>
        /// Gets or sets the last position.
        /// </summary>
        /// <value>The last position.</value>
        protected int LastPosition { get; set; }

        /// <summary>
        /// Adds the specified item in the set.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        public virtual void Add(T item)
        {
            if (this.LastPosition == this.Set.Length)
            {
                this.FullSetHandler();
            }

            this.Set[this.LastPosition] = item;
            this.LastPosition++;
        }

        /// <summary>
        /// Determines whether the set contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the set contains the specified item; otherwise, <c>false</c>.</returns>
        public virtual bool Contains(T item) => this.Set.Contains(item);

        /// <summary>
        /// Inserts the specified item at the specified index in the set.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        /// <param name="index">The index where the item will be inserted.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Insert(T item, int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the first occurence of the specified item from the set.
        /// </summary>
        /// <param name="item">The item which will be removed.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes all items from the set that match the given item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void RemoveAll(T item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the item at the specified index.
        /// </summary>
        /// <param name="index">The index of the item we want to remove.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns the count of items in the set.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int Size()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Handles the behaviour when the set is at full capacity.
        /// </summary>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void FullSetHandler()
        {
            this.ResizeSet(2);
        }

        /// <summary>
        /// Resizes the set.
        /// </summary>
        /// <param name="multiplier">The multiplier.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        protected virtual void ResizeSet(int multiplier)
        {
            var resizedSet = new T[this.Set.Length * multiplier];
            Parallel.For(0, this.Set.Length, i => { resizedSet[i] = this.Set[i]; });
            this.Set = resizedSet;
        }
    }
}