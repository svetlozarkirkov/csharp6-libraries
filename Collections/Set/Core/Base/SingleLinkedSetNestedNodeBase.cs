namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;

    /// <summary>
    /// Class SingleLinkedSetNestedNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ISingleLinkSet{T}" />
    public abstract class SingleLinkedSetNestedNodeBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// The _last node
        /// </summary>
        private readonly Node _lastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkedSetNestedNodeBase{T}"/> class.
        /// </summary>
        protected SingleLinkedSetNestedNodeBase()
        {
            this._lastNode = new Node();
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            this._lastNode.PreviousNode = this._lastNode;
            this._lastNode.Item = item;
        }

        /// <summary>
        /// Class Node.
        /// </summary>
        private class Node
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            internal Node()
            {
            }

            /// <summary>
            /// Gets or sets the previous node.
            /// </summary>
            /// <value>The previous node.</value>
            internal Node PreviousNode { get; set; }

            /// <summary>
            /// Gets or sets the item.
            /// </summary>
            /// <value>The item.</value>
            internal T Item { get; set; }
        }
    }
}