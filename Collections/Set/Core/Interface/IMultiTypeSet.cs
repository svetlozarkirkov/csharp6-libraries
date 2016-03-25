namespace Collections.Set.Core.Interface
{
    /// <summary>
    /// Interface IMultiTypeSet
    /// </summary>
    public interface IMultiTypeSet
    {
        /// <summary>
        /// Adds an item into the set.
        /// </summary>
        /// <typeparam name="T">The type of the inserted item.</typeparam>
        /// <param name="item">The item to be inserted.</param>
        void Add<T>(T item);

        /// <summary>
        /// Removes the item at the specified index in the set.
        /// </summary>
        /// <param name="index">The index of the removed item.</param>
        void RemoveAt(int index);

        /// <summary>
        /// Removes a specific item from the set.
        /// </summary>
        /// <typeparam name="T">The type of the removed item.</typeparam>
        /// <param name="item">The item to be removed.</param>
        void Remove<T>(T item);

        /// <summary>
        /// Gets the item at the specified index in the set.
        /// </summary>
        /// <typeparam name="T">The type of the item to be returned.</typeparam>
        /// <param name="index">The index of the returned item.</param>
        /// <returns></returns>
        T Get<T>(int index);
    }
}