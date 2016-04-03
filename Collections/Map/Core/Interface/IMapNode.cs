namespace Collections.Map.Core.Interface
{
    using Collections.Injectors.Node.Interface;

    /// <summary>
    /// Interface IMapNode
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Collections.Injectors.Node.Interface.IDoubleLinkNode" />
    public interface IMapNode<TKey, TValue> : IDoubleLinkNode
    {
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