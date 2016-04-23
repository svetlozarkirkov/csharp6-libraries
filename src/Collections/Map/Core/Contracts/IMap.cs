namespace Collections.Map.Core.Contracts
{
    using Collections.Core.Contracts;

    /// <summary>
    /// Interface IMap
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public interface IMap<in TKey, TValue> : ICollection
    {
        /// <summary>
        /// Stores the specified key and associated value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        void Store(TKey key, TValue value);

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        TValue Retrieve(TKey key);

        /// <summary>
        /// Determines whether the map contains the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if the map contains the key; otherwise, <c>false</c>.</returns>
        bool HasKey(TKey key);

        /// <summary>
        /// Determines whether the map contains the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the map contains the value; otherwise, <c>false</c>.</returns>
        bool HasValue(TValue value);
    }
}