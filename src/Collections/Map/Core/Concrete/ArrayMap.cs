namespace Collections.Map.Core.Concrete
{
    using Collections.Core.Exceptions;
    using Collections.Map.Core.Base;

    /// <summary>
    /// Class ArrayMap.
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    /// <typeparam name="TValue">The type of the t value.</typeparam>
    /// <seealso cref="Collections.Map.Core.Base.ArrayMapBase{TKey, TValue}" />
    public class ArrayMap<TKey, TValue> : ArrayMapBase<TKey, TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayMap{TKey, TValue}"/> class.
        /// </summary>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        public ArrayMap()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayMap{TKey, TValue}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        public ArrayMap(int capacity) : base(capacity)
        {
        }
    }
}