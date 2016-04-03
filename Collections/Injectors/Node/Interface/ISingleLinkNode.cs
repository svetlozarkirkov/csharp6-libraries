namespace Collections.Injectors.Node.Interface
{
    /// <summary>
    /// Interface ISingleLinkNode
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="INode" />
    public interface ISingleLinkNode<T> : INode
    {
        /// <summary>
        /// Gets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        INode PreviousNode { get; set; }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <value>The item.</value>
        T Item { get; set; }
    }
}