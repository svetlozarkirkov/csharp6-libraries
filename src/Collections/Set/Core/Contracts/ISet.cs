namespace Collections.Set.Core.Contracts
{
    using Collections.Core.Contracts;

    /// <summary>
    /// Interface ISet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISet<T> : ICollection<T>
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
        /// Removes the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// TODO Edit XML Comment Template for Remove
        void Remove(int index);

        /// <summary>
        /// Determines whether the set contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the set contains the specified item; otherwise, <c>false</c>.</returns>
        bool Contains(T item);
    }
}