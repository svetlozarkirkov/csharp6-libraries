namespace ML.Map.Core.Contracts
{
    /// <summary>
    /// Interface IMap
    /// </summary>
    /// <typeparam name="TKey">The type of the keys.</typeparam>
    /// <typeparam name="TValue">The type of the values.</typeparam>
    public interface IMap<in TKey, TValue>
    {
        /// <summary>
        /// Adds the specified <paramref name="key"/> and its <paramref name="value"/> into the map.
        /// </summary>
        /// <param name="key">The <paramref name="key"/>.</param>
        /// <param name="value">The <paramref name="value"/>.</param>
        void Add(TKey key, TValue value);

        /// <summary>
        /// Gets the value associated with the specified <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The <paramref name="key"/>.</param>
        /// <returns><typeparamref name="TValue"/>.</returns>
        TValue Get(TKey key);

        /// <summary>
        /// Determines whether the specified <paramref name="key"/> exists in the map.
        /// </summary>
        /// <param name="key">The <paramref name="key"/>.</param>
        /// <returns><c><see langword="true"/></c> if the specified key exists in the map; otherwise, <c>false</c>.</returns>
        bool HasKey(TKey key);

        /// <summary>
        /// Determines whether the specified <paramref name="value"/> exists in the map.
        /// </summary>
        /// <param name="value">The <paramref name="value"/>.</param>
        /// <returns><c><see langword="true"/></c> if the specified value exists in the map; otherwise, <c>false</c>.</returns>
        bool HasValue(TValue value);

        /// <summary>
        /// Returns the count of key/value pairs in the map.
        /// </summary>
        /// <returns>System.Int32.</returns>
        int Size();
    }
}