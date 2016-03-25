namespace Collections.Set.Node.Base
{
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class LinkedSetNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Node.Interface.ILinkedSetNode{T}" />
    public abstract class LinkedSetNodeBase<T> : ILinkedSetNode<T>
    {
        /// <summary>
        /// The _node item
        /// </summary>
        private readonly T _item;

        /// <summary>
        /// The _previous item
        /// </summary>
        private ILinkedSetNode<T> _previousNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedSetNodeBase{T}" /> class.
        /// </summary>
        /// <param name="previousNode">The previous node.</param>
        /// <param name="item">The item.</param>
        protected LinkedSetNodeBase(ILinkedSetNode<T> previousNode, T item)
        {
            this._item = item;
            this.SetPreviousNode(previousNode);
        }

        /// <summary>
        /// Sets the previous node.
        /// </summary>
        /// <param name="previousNode">The previous node.</param>
        private void SetPreviousNode(ILinkedSetNode<T> previousNode)
        {
            this._previousNode = previousNode;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() =>
            $"[ Node item: {this._item} ] [Previous Node: {this._previousNode}";
    }
}