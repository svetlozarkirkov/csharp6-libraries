namespace Collections.Map.Core.Base
{
    using System;
    using System.Collections;
    using System.Linq;
    using Collections.Map.Core.Interface;

    /// <summary>
    /// Class NodeMapBase.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Interface.IMap{TKey, TValue}" />
    public abstract class NodeMapBase<TKey, TValue> : IMap<TKey, TValue>, IEnumerable
    {
        /// <summary>
        /// The first node
        /// </summary>
        protected MapNode FirstNode;

        /// <summary>
        /// The last node
        /// </summary>
        protected MapNode LastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMapBase{TKey, TValue}"/> class.
        /// </summary>
        protected NodeMapBase()
        {
            this.FirstNode = this.LastNode = new MapNode();
        }

        /// <summary>
        /// Gets the size of the Map.
        /// </summary>
        /// <value>The count of items in the Map.</value>
        public int Size { get; private set; }

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
                Key = key,
                Value = value
            };

            this.LastNode.PreviousNode.NextNode = this.LastNode;
            this.Size++;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="ArgumentException">Key not found.</exception>
        public TValue Retrieve(TKey key)
        {
            foreach (var item in this.Cast<IMapItem<TKey, TValue>>())
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }

            throw new ArgumentException("Key not found.");
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        public IEnumerator GetEnumerator()
        {
            var currentNode = this.FirstNode.NextNode;
            while (currentNode != null)
            {
                yield return new {currentNode.Key, currentNode.Value};
                currentNode = currentNode.NextNode;
            }
        }

        /// <summary>
        /// Class MapNodeSeparate.
        /// </summary>
        /// <seealso cref="Interface.IMapNode{TKey, TValue}" />
        protected class MapNode : IMapNode<TKey, TValue>
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