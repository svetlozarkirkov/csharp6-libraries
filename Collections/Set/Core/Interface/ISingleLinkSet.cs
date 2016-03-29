namespace Collections.Set.Core.Interface
{
    using Collections.Set.Node.Interface;

    /// <summary>
    /// Interface ISingleLinkSet
    /// </summary>
    internal interface ISingleLinkSet<T> : ISet<T>
    {
        ISingleLinkNode<T> LastNode { get; set; }
    }
}