namespace Collections.Set.Core.Base
{
    using System;
    using Collections.Set.Core.Interface;

    /// <summary>
    /// Class SingleLinkSetBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Interface.ISingleLinkSet{T}" />
    [Serializable]
    public abstract class SingleLinkSetBase<T> : ISingleLinkSet<T>
    {
        /// <summary>
        /// The _last node
        /// </summary>
        private SingleLinkSetNode _lastSingleLinkSetNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkSetBase{T}" /> class.
        /// </summary>
        protected SingleLinkSetBase()
        {
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(T item)
        {
            if (this._lastSingleLinkSetNode == null)
            {
                this._lastSingleLinkSetNode = new SingleLinkSetNode(item);
            }
            else
            {
                this._lastSingleLinkSetNode.Update(this._lastSingleLinkSetNode, item);
            }
        }

        /// <summary>
        /// Private SingleLinkSetNode class
        /// </summary>
        [Serializable]
        private class SingleLinkSetNode
        {
            /// <summary>
            /// The _previous node
            /// </summary>
            private SingleLinkSetNode _previousSingleLinkSetNode;
            /// <summary>
            /// The _item
            /// </summary>
            private T _item;

            /// <summary>
            /// Initializes a new instance of the <see cref="SingleLinkSetNode"/> class.
            /// </summary>
            /// <param name="item">The item.</param>
            internal SingleLinkSetNode(T item)
            {
                this._previousSingleLinkSetNode = null;
                this._item = item;
            }

            /// <summary>
            /// Updates the specified previous node.
            /// </summary>
            /// <param name="previousSingleLinkSetNode">The previous node.</param>
            /// <param name="item">The item.</param>
            internal void Update(SingleLinkSetNode previousSingleLinkSetNode, T item)
            {
                this._previousSingleLinkSetNode = previousSingleLinkSetNode;
                this._item = item;
            }
        }
    }
}