namespace Collections.Set.Node.Base
{
    using System;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class SingleLinkNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Node.Interface.ISingleLinkNode{T}" />
    [Serializable]
    internal abstract class SingleLinkNodeBase<T> : ISingleLinkNode<T>
    {
        /// <summary>
        /// The _node item
        /// </summary>
        protected T Item;

        /// <summary>
        /// The _previous item
        /// </summary>
        protected ISingleLinkNode<T> PreviousNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkNodeBase{T}" /> class.
        /// </summary>
        protected SingleLinkNodeBase()
        {
        }

        /// <summary>
        /// Updates the node.
        /// </summary>
        /// <param name="previousNode">The previousNode.</param>
        /// <param name="item">The item.</param>
        public void Update(ISingleLinkNode<T> previousNode, T item)
        {
            this.PreviousNode = previousNode;
            this.Item = item;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() =>
            $"[ Item: {this.Item} ] [ Previous Node: {this.PreviousNode} ]";
    }
}