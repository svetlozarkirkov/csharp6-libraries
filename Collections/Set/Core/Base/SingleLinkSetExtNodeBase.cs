namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class SingleLinkSetExtNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ISingleLinkSet{T}" />
    public abstract class SingleLinkSetExtNodeBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkSetExtNodeBase{T}"/> class.
        /// </summary>
        protected SingleLinkSetExtNodeBase(ISingleLinkNode<T> node)
        {
            this.LastNode = node;
        }

        /// <summary>
        /// Gets or sets the last node.
        /// </summary>
        /// <value>The last node.</value>
        public ISingleLinkNode<T> LastNode { get; set; }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            this.LastNode.PreviousNode = this.LastNode;
            this.LastNode.Item = item;
        }
    }
}