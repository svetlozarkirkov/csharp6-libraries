namespace Collections.Map.Core.Base
{
    using Collections.Map.Core.Interface;

    /// <summary>
    /// Class MapBase.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Interface.IMap{TKey, TValue}" />
    public abstract class MapBase<TKey, TValue> : IMap<TKey, TValue>
    {
        /// <summary>
        /// Stores the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Store(TKey key, TValue value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TValue GetValue(TKey key)
        {
            throw new System.NotImplementedException();
        }
    }
}