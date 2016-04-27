namespace Collections.Set.Core.Base
{
    using Collections.Core.Base;
    using Collections.Set.Core.Contracts;

    /// <summary>
    /// Class ArraySet.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Core.Base.ArrayCollectionBase{T}" />
    /// <seealso cref="Contracts.ISet{T}" />
    /// TODO Edit XML Comment Template for ArraySetBase
    public class ArraySet<T> : ArrayCollectionBase<T>, ISet<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySet{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// TODO Edit XML Comment Template for #ctor
        public ArraySet(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySet{T}"/> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public ArraySet()
        {
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Add
        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Remove
        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Remove
        public void Remove(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the set contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the set contains the specified item; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Contains
        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the size of the collection.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Size
        public override int Size()
        {
            throw new System.NotImplementedException();
        }
    }
}