﻿namespace Collections.Injectors.Node.Interface
{
    /// <summary>
    /// Interface IDoubleLinkNode
    /// </summary>
    /// <seealso cref="Interface.INode" />
    public interface IDoubleLinkNode : INode
    {
        /// <summary>
        /// Gets or sets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        INode PreviousNode { get; set; }

        /// <summary>
        /// Gets or sets the next node.
        /// </summary>
        /// <value>The next node.</value>
        INode NextNode { get; set; }
    }
}