namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;

    /// <summary>
    /// Class MultiTypeSetBase.
    /// </summary>
    /// <seealso cref="Collections.Set.Core.Interface.IMultiTypeSet" />
    public abstract class MultiTypeSetBase : IMultiTypeSet
    {
        /// <summary>
        /// Adds an item into the set.
        /// </summary>
        /// <typeparam name="T">The type of the inserted item.</typeparam>
        /// <param name="item">The item to be inserted.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Add<T>(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the item at the specified index in the set.
        /// </summary>
        /// <param name="index">The index of the removed item.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes a specific item from the set.
        /// </summary>
        /// <typeparam name="T">The type of the removed item.</typeparam>
        /// <param name="item">The item to be removed.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Remove<T>(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the item at the specified index in the set.
        /// </summary>
        /// <typeparam name="T">The type of the item to be returned.</typeparam>
        /// <param name="index">The index of the returned item.</param>
        /// <returns>T.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T Get<T>(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}