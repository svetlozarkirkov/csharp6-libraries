namespace Collections.Set.Core.Base
{
    using System;
    using Collections.Set.Core.Interface;

    /// <summary>
    /// Class SingleLinkedSetAnonymousNodeBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ISingleLinkSet{T}" />
    [Serializable]
    public abstract class SingleLinkedSetAnonymousNodeBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// The _last node
        /// </summary>
        private object _lastNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkedSetAnonymousNodeBase{T}" /> class.
        /// </summary>
        protected SingleLinkedSetAnonymousNodeBase()
        {
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            this._lastNode = new {PreviousNode = this._lastNode, Item = item};
        }
    }
}