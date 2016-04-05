namespace Collections.Injectors.Node.Interface
{
    /// <summary>
    /// Interface ISingleLinkNode
    /// </summary>
    /// <seealso cref="Interface.INode" />
    public interface ISingleLinkNode : INode
    {
        /// <summary>
        /// Gets or sets the next node.
        /// </summary>
        /// <value>The next node.</value>
        INode NextNode { get; set; }
    }
}