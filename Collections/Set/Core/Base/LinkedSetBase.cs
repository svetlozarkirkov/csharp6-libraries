namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;
    using Collections.Set.Node.Concrete;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class LinkedSetBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ILinkedSet{T}" />
    public abstract class LinkedSetBase<T> : ILinkedSet<T>
    {
        /// <summary>
        /// The _last node
        /// </summary>
        private ILinkedSetNode<T> _lastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedSetBase{T}" /> class.
        /// </summary>
        protected LinkedSetBase()
        {
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            this._lastNode = this._lastNode ==
                null ? new LinkedSetNode<T>(null, item) : new LinkedSetNode<T>(this._lastNode, item);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => this._lastNode.ToString();
    }
}