namespace Collections.Set.Node.Concrete
{
    using Collections.Set.Node.Base;
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Class LinkedSetNode.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Set.Node.Base.LinkedSetNodeBase{T}" />
    public class LinkedSetNode<T> : LinkedSetNodeBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedSetNode{T}"/> class.
        /// </summary>
        /// <param name="previousNode">The previous node.</param>
        /// <param name="item">The item.</param>
        public LinkedSetNode(ILinkedSetNode<T> previousNode, T item)
            : base(previousNode, item)
        {
        }
    }
}