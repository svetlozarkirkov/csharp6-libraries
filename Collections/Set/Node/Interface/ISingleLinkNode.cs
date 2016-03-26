namespace Collections.Set.Node.Interface
{
    /// <summary>
    /// Interface ISingleLinkNode
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface ISingleLinkNode<T> : ISetNode<T>
    {
        void Update(ISingleLinkNode<T> previousNode, T item);
    }
}