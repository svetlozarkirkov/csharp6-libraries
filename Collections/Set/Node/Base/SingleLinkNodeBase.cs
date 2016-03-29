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
    public abstract class SingleLinkNodeBase<T> : ISingleLinkNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkNodeBase{T}" /> class.
        /// </summary>
        protected SingleLinkNodeBase()
        {
        }

        /// <summary>
        /// Gets the previous node.
        /// </summary>
        /// <value>The previous node.</value>
        public ISingleLinkNode<T> PreviousNode { get; set; }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <value>The item.</value>
        public T Item { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() =>
            $"[ Item: {this.Item} ] [ Previous Node: {this.PreviousNode} ]";
    }
}