namespace Collections.Set.Core.Interface
{
    /// <summary>
    /// Interface ISet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface ISet<in T>
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Add(T item);
    }
}