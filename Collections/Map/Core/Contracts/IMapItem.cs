namespace Collections.Map.Core.Contracts
{
    /// <summary>
    /// Interface IMapItem
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    /// <typeparam name="TValue">The type of the t value.</typeparam>
    public interface IMapItem<TKey, TValue>
    {
        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <value>The key.</value>
        TKey Key { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        TValue Value { get; set; }
    }
}