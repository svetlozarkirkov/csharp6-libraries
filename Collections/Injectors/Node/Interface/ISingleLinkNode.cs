namespace Collections.Injectors.Node.Interface
{
    /// <summary>
    /// Interface ISingleLinkNode
    /// </summary>
    /// <seealso cref="Interface.INode" />
    public interface ISingleLinkNode : INode
    {
        /// <summary>
        /// Gets or sets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        INode PreviousNode { get; set; }
    }
}