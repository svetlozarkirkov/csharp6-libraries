namespace ML.Set.Core.Contracts
{
    /// <summary>
    /// Interface ISet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// TODO Edit XML Comment Template for ISet
    public interface ISet<T>
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// TODO Edit XML Comment Template for Add
        void Add(T item);

        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if [contains] [the specified item]; otherwise, <c>false</c>.</returns>
        /// TODO Edit XML Comment Template for Contains
        bool Contains(T item);

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// TODO Edit XML Comment Template for Remove
        void Remove(T item);

        /// <summary>
        /// Removes at.
        /// </summary>
        /// <param name="index">The index.</param>
        /// TODO Edit XML Comment Template for RemoveAt
        void RemoveAt(int index);

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        int Size();
    }
}