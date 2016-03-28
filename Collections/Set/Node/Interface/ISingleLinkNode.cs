namespace Collections.Set.Node.Interface
{
    /// <summary>
    /// Interface ISingleLinkNode
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Node.Interface.ISetNode{T}" />
    internal interface ISingleLinkNode<T> : ISetNode<T>
    {
        /// <summary>
        /// Updates the node.
        /// </summary>
        /// <param name="previousNode">The previousNode.</param>
        /// <param name="item">The item.</param>
        void Update(ISingleLinkNode<T> previousNode, T item);
    }
}