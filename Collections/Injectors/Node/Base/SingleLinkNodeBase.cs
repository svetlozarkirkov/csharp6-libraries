namespace Collections.Injectors.Node.Base
{
    using Collections.Injectors.Node.Interface;

    /// <summary>
    /// Class SingleLinkNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="ISingleLinkNode{T}" />
    public abstract class SingleLinkNodeBase<T> : ISingleLinkNode<T>
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