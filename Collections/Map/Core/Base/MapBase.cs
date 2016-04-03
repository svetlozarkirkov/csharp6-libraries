namespace Collections.Map.Core.Base
{
    using Collections.Injectors.Node.Interface;
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
        /// The last node
        /// </summary>
        protected IMapNode<TKey, TValue> LastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapBase{TKey, TValue}"/> class.
        /// </summary>
        protected MapBase()
        {
        }

        /// <summary>
        /// Stores the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Store(TKey key, TValue value)
        {
            this.LastNode = new MapNode
            {
                PreviousNode = this.LastNode,
                NextNode = null,
                Key = key,
                Value = value
            };
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

        /// <summary>
        /// Class MapNode.
        /// </summary>
        /// <seealso cref="Collections.Map.Core.Interface.IMapNode{TKey, TValue}" />
        protected class MapNode : IMapNode<TKey, TValue>
        {
            /// <summary>
            /// Gets or sets the previous node.
            /// </summary>
            /// <value>The previous node.</value>
            public INode PreviousNode { get; set; }

            /// <summary>
            /// Gets or sets the next node.
            /// </summary>
            /// <value>The next node.</value>
            public INode NextNode { get; set; }

            /// <summary>
            /// Gets or sets the key.
            /// </summary>
            /// <value>The key.</value>
            public TKey Key { get; set; }

            /// <summary>
            /// Gets or sets the value.
            /// </summary>
            /// <value>The value.</value>
            public TValue Value { get; set; }
        }
    }
}