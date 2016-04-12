namespace Collections.Map.Core.Base
{
    using Collections.Map.Core.Interface;

    /// <summary>
    /// Class ArrayMapBase.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Interface.IMap{TKey, TValue}" />
    public abstract class ArrayMapBase<TKey, TValue> : IMap<TKey, TValue>
    {
        /// <summary>
        /// Gets the size of the Map.
        /// </summary>
        /// <value>The count of items in the Map.</value>
        public int Size { get; }

        /// <summary>
        /// Stores the specified key and associated value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Store(TKey key, TValue value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TValue Retrieve(TKey key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the map contains the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if the map contains the key; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasKey(TKey key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the map contains the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the map contains the value; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasValue(TValue value)
        {
            throw new System.NotImplementedException();
        }
    }
}