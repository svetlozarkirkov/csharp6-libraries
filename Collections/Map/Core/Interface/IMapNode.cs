namespace Collections.Map.Core.Interface
{
    /// <summary>
    /// Interface IMapNode
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public interface IMapNode<TKey, TValue>
    {
        /// <summary>
        /// Gets or sets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        IMapNode<TKey, TValue> PreviousNode { get; set; }

        /// <summary>
        /// Gets or sets the next node.
        /// </summary>
        /// <value>The next node.</value>
        IMapNode<TKey, TValue> NextNode { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The key.</value>
        TKey Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        TValue Value { get; set; }
    }
}