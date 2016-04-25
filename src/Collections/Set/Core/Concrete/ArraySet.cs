namespace Collections.Set.Core.Concrete
{
    using Collections.Set.Core.Base;

    /// <summary>
    /// Class ArraySet.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Base.ArraySetBase{T}" />
    /// TODO Edit XML Comment Template for ArraySet
    public class ArraySet<T> : ArraySetBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySet{T}"/> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public ArraySet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySet{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// TODO Edit XML Comment Template for #ctor
        public ArraySet(int capacity) : base(capacity)
        {
        }
    }
}