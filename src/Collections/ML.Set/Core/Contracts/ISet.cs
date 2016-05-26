namespace ML.Set.Core.Contracts
{
    /// <summary>
    /// Interface ISet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISet<T>
    {
        /// <summary>
        /// Adds the specified item in the set.
        /// </summary>
        /// <param name="item">The item.</param>
        void Add(T item);

        /// <summary>
        /// Determines whether the set contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the set contains the specified item; otherwise, <c>false</c>.</returns>
        bool Contains(T item);

        /// <summary>
        /// Inserts the specified item at the specified index in the set.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="index">The index.</param>
        void Insert(T item, int index);

        /// <summary>
        /// Removes the specified item from the set.
        /// </summary>
        /// <param name="item">The item which will be removed.</param>
        void Remove(T item);

        /// <summary>
        /// Removes the item at the specified index.
        /// </summary>
        /// <param name="index">The index of the item we want to remove.</param>
        void RemoveAt(int index);

        /// <summary>
        /// Returns the count of items in the set.
        /// </summary>
        /// <returns>System.Int32.</returns>
        int Size();
    }
}