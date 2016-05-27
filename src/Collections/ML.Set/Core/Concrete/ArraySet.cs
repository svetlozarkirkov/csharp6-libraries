namespace ML.Set.Core.Concrete
{
    using ML.Set.Core.Base;
    using ML.Set.Core.Exceptions;

    /// <summary>
    /// Class ArraySet.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Base.ArraySetBase{T}" />
    public class ArraySet<T> : ArraySetBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySet{T}"/> class.
        /// </summary>
        /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
        public ArraySet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySet{T}"/> class.
        /// </summary>
        /// <param name="capacity">The set capacity.</param>
        /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
        public ArraySet(int capacity) : base(capacity)
        {
        }
    }
}