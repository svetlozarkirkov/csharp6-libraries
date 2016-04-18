namespace Collections.Map.Core.Base
{
    using System;
    using System.Collections;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using Collections.Map.Core.Contracts;

    /// <summary>
    /// Class NodeMapBase.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Contracts.IMap{TKey, TValue}" />
    public abstract class NodeMapBase<TKey, TValue> : IMap<TKey, TValue>, IEnumerable
    {
        /// <summary>
        /// The first node
        /// </summary>
        protected IMapNode<TKey, TValue> StartNode;

        /// <summary>
        /// The last node
        /// </summary>
        protected IMapNode<TKey, TValue> LastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMapBase{TKey, TValue}"/> class.
        /// </summary>
        protected NodeMapBase()
        {
            this.StartNode = this.LastNode = new MapNode();
        }

        /// <summary>
        /// Gets the size of the Map.
        /// </summary>
        /// <value>The count of items in the Map.</value>
        public int Size { get; private set; }

        /// <summary>
        /// Stores the specified key and associated value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Store(TKey key, TValue value)
        {
            Contract.Requires(key != null);
            Contract.Requires(value != null);

            this.LastNode = this.LastNode.NextNode = new MapNode
            {
                Key = key,
                Value = value
            };

            this.Size++;
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="ArgumentException">Invalid key.</exception>
        public TValue Retrieve(TKey key)
        {
            Contract.Requires(key != null);

            foreach (var item in this.Cast<MapItem>().Where(item => item.Key.Equals(key)))
            {
                return item.Value;
            }

            throw new ArgumentException("Invalid key given.");
        }

        /// <summary>
        /// Determines whether the map contains the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if the map contains the key; otherwise, <c>false</c>.</returns>
        public bool HasKey(TKey key)
            => this.Cast<MapItem>().Any(item => item.Key.Equals(key));

        /// <summary>
        /// Determines whether the map contains the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the map contains the value; otherwise, <c>false</c>.</returns>
        public bool HasValue(TValue value)
            => this.Cast<MapItem>().Any(item => item.Value.Equals(value));

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        public IEnumerator GetEnumerator()
        {
            var currentNode = this.StartNode.NextNode;
            var output = new MapItem();

            while (currentNode != null)
            {
                output.Key = currentNode.Key;
                output.Value = currentNode.Value;

                yield return output;

                currentNode = currentNode.NextNode;
            }
        }

        /// <summary>
        /// Class MapNode.
        /// </summary>
        protected class MapNode : IMapNode<TKey, TValue>
        {
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

        /// <summary>
        /// Class MapItem.
        /// </summary>
        /// <seealso cref="Contracts.IMapItem{TKey, TValue}" />
        protected class MapItem : IMapItem<TKey, TValue>
        {
            /// <summary>
            /// Gets the key.
            /// </summary>
            /// <value>The key.</value>
            public TKey Key { get; set; }

            /// <summary>
            /// Gets the value.
            /// </summary>
            /// <value>The value.</value>
            public TValue Value { get; set; }
        }
    }
}