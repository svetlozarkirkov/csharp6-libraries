// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArrayMap.cs" company="">
//   
// </copyright>
// <summary>
//   Class ArrayMap.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ML.Map.Core.Concrete
{
    using ML.Map.Core.Base;
    using ML.Map.Core.Exceptions;

    /// <summary>
    /// Class ArrayMap.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys.</typeparam>
    /// <typeparam name="TValue">The type of the values.</typeparam>
    /// <seealso cref="Base.ArrayMapBase{TKey, TValue}" />
    public class ArrayMap<TKey, TValue> : ArrayMapBase<TKey, TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayMap{TKey, TValue}"/> class.
        /// </summary>
        /// <exception cref="InvalidMapCapacityException">If the capacity is zero or less.</exception>
        public ArrayMap()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayMap{TKey, TValue}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="InvalidMapCapacityException">If the capacity is zero or less.</exception>
        public ArrayMap(int capacity) : base(capacity)
        {
        }
    }
}