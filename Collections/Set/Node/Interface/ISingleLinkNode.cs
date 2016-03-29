namespace Collections.Set.Node.Interface
{
    /// <summary>
    /// Interface ISingleLinkNode
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Node.Interface.ISetNode{T}" />
    public interface ISingleLinkNode<T> : ISetNode<T>
    {
        /// <summary>
        /// Gets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        ISingleLinkNode<T> PreviousNode { get; set; }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <value>The item.</value>
        T Item { get; set; }
    }
}