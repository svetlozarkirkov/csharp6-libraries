namespace Collections.Map.Core.Base
{
    using Collections.Map.Core.Interface;

    /// <summary>
    /// Class NodeMapBase.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Interface.IMap{TKey, TValue}" />
    public abstract class NodeMapBase<TKey, TValue> : IMap<TKey, TValue>
    {
        /// <summary>
        /// The last node
        /// </summary>
        public IMapNode<TKey, TValue> CurrentNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMapBase{TKey, TValue}"/> class.
        /// </summary>
        protected NodeMapBase()
        {
        }

        /// <summary>
        /// Stores the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Store(TKey key, TValue value)
        {
            // TODO: Rethink
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TValue Retrieve(TKey key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Class MapNode.
        /// </summary>
        /// <seealso cref="Interface.IMapNode{TKey, TValue}" />
        public class MapNode : IMapNode<TKey, TValue>
        {
            /// <summary>
            /// Gets or sets the previous node.
            /// </summary>
            /// <value>The previous node.</value>
            public IMapNode<TKey, TValue> PreviousNode { get; set; }

            /// <summary>
            /// Gets or sets the next node.
            /// </summary>
            /// <value>The next node.</value>
            public IMapNode<TKey, TValue> NextNode { get; set; }

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