namespace ML.Map.Core.Base
{
    using ML.Map.Core.Contracts;
    using ML.Map.Core.Exceptions;

    /// <summary>
    /// Class ArrayMapBase.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys.</typeparam>
    /// <typeparam name="TValue">The type of the values.</typeparam>
    /// <seealso cref="Contracts.IMap{TKey, TValue}" />
    public abstract class ArrayMapBase<TKey, TValue> : IMap<TKey, TValue>
    {
        /// <exception cref="InvalidMapCapacityException">If the capacity is zero or less.</exception>
        protected ArrayMapBase(int capacity)
        {
            if (capacity <= 0)
            {
                throw new InvalidMapCapacityException(
                    nameof(capacity),
                    capacity,
                    "Map capacity should be greater than zero.");
            }

            this.Map = new IMapPair<TKey, TValue>[capacity];
            this.LastPosition = 0;
        }

        /// <exception cref="InvalidMapCapacityException">If the capacity is zero or less.</exception>
        protected ArrayMapBase() : this(DefaultMapCapacity) { }

        protected static int DefaultMapCapacity => 16;

        protected IMapPair<TKey, TValue>[] Map { get; set; }

        protected int LastPosition { get; set; }

        /// <summary>
        /// Adds the specified key and its value into the map.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(TKey key, TValue value)
        {

        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TValue Get(TKey key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the specified key exists in the map.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if the specified key exists in the map; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasKey(TKey key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the specified value exists in the map.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value exists in the map; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasValue(TValue value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns the count of key/value pairs in the map.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int Size()
        {
            throw new System.NotImplementedException();
        }
    }
}