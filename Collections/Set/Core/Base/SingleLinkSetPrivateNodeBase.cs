namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class SingleLinkSetPrivateNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ISingleLinkSet{T}" />
    public abstract class SingleLinkSetPrivateNodeBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            if (this.LastNode == null)
            {
                this.LastNode = new Node();
            }

            this.LastNode.PreviousNode = this.LastNode;
            this.LastNode.Item = item;
        }

        /// <summary>
        /// Gets or sets the last node.
        /// </summary>
        /// <value>The last node.</value>
        public ISingleLinkNode<T> LastNode { get; set; }

        /// <summary>
        /// Class Node.
        /// </summary>
        /// <seealso cref="Collections.Set.Node.Interface.ISingleLinkNode{T}" />
        private class Node : ISingleLinkNode<T>
        {
            /// <summary>
            /// Gets the previous node.
            /// </summary>
            /// <value>The previous node.</value>
            public ISingleLinkNode<T> PreviousNode { get; set; }

            /// <summary>
            /// Gets the item.
            /// </summary>
            /// <value>The item.</value>
            public T Item { get; set; }
        }
    }
}