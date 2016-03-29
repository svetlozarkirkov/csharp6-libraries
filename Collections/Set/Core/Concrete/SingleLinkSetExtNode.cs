namespace Collections.Set.Core.Concrete
{
    using Collections.Set.Core.Base;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class SIngleLinkSet.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Core.Base.SingleLinkSetExtNodeBase{T}" />
    public class SingleLinkSetExtNode<T> : SingleLinkSetExtNodeBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkSetExtNode{T}"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public SingleLinkSetExtNode(ISingleLinkNode<T> node) : base(node)
        {
        }
    }
}