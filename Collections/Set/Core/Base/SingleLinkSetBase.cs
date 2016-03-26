namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;
    using Collections.Set.Node.Concrete;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class SingleLinkSetBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ISingleLinkSet{T}" />
    public abstract class SingleLinkSetBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// The _last node
        /// </summary>
        private readonly ISingleLinkNode<T> _lastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkSetBase{T}" /> class.
        /// </summary>
        protected SingleLinkSetBase()
        {
            this._lastNode = new SingleLinkNode<T>();
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        //  TODO: Avoid instantiation of concrete single link node.
        public void Add(T item)
        {
            this._lastNode.Update(this._lastNode, item);
        }
    }
}