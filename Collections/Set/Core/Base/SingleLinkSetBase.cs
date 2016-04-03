namespace Collections.Set.Core.Base
{
    using Collections.Injectors.Node.Interface;
    using Collections.Set.Core.Interface;

    /// <summary>
    /// Class SingleLinkSetBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Interface.ISingleLinkSet{T}" />
    public abstract class SingleLinkSetBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// The last node
        /// </summary>
        protected SingleLinkSetNode LastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkSetBase{T}"/> class.
        /// </summary>
        protected SingleLinkSetBase()
        {
            this.LastNode = new SingleLinkSetNode();
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            this.LastNode.PreviousNode = this.LastNode;
            this.LastNode.Item = item;
        }

        /// <summary>
        /// Class SingleLinkSetNode.
        /// </summary>
        /// <seealso cref="ISingleLinkNode{T}" />
        protected class SingleLinkSetNode : ISingleLinkSetNode<T>
        {
            /// <summary>
            /// Gets the previous node.
            /// </summary>
            /// <value>The previous node.</value>
            public INode PreviousNode { get; set; }

            /// <summary>
            /// Gets the item.
            /// </summary>
            /// <value>The item.</value>
            public T Item { get; set; }
        }
    }
}