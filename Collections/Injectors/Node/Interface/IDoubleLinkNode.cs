namespace Collections.Injectors.Node.Interface
{
    /// <summary>
    /// Interface IDoubleLinkNode
    /// </summary>
    /// <seealso cref="ISingleLinkNode" />
    public interface IDoubleLinkNode : ISingleLinkNode
    {
        /// <summary>
        /// Gets or sets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        INode PreviousNode { get; set; }
    }
}