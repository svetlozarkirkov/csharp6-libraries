namespace Collections.Set.Core.Base
{
    using Collections.Set.Core.Interface;

    /// <summary>
    /// Class NodeSetBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Interface.ISet{T}" />
    public abstract class NodeSetBase<T> : ISet<T>
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the set contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the set contains the specified item; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}