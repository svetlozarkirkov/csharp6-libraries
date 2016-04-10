namespace Collections.Set.Core.Interface
{
    using Collections.Core.Interface;

    /// <summary>
    /// Interface ISet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISet<in T> : ICollection
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Add(T item);

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Remove(T item);

        /// <summary>
        /// Determines whether the set contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the set contains the specified item; otherwise, <c>false</c>.</returns>
        bool Contains(T item);
    }
}