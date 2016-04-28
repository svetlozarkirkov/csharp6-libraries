namespace Collections.Map.Core.Base
{
    using System;
    using System.Diagnostics.Contracts;
    using Collections.Core.Base;
    using Collections.Core.Exceptions;
    using Collections.Map.Core.Contracts;
    using Collections.Map.Exceptions.ArrayMap;

    /// <summary>
    /// Class ArrayMap.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso>
    ///     <cref>Collections.Core.Base.ArrayCollectionBase{IMapItem{TKey, TValue}}</cref>
    /// </seealso>
    /// <seealso cref="Contracts.IMap{TKey, TValue}" />
    public class ArrayMap<TKey, TValue>
        : ArrayCollectionBase<IMapItem<TKey, TValue>>, IMap<TKey, TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayMap{TKey, TValue}" /> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        public ArrayMap(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayMap{TKey, TValue}" /> class.
        /// </summary>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        public ArrayMap()
        {
        }

        /// <summary>
        /// Stores the specified key and associated value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        public void Store(TKey key, TValue value)
        {
            Contract.Requires(key != null);
            Contract.Requires(value != null);

            if (this.CurrentPosition == this.Collection.Length)
            {
                this.ResizeCollection(2);
            }

            this.Collection[this.CurrentPosition] =
                new MapItem { Key = key, Value = value };

            this.CurrentPosition++;
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TValue Retrieve(TKey key)
        {
            Contract.Requires(key != null);

            for (var i = 0; i < this.CurrentPosition; i++)
            {
                if (this.Collection[i].Key.Equals(key))
                {
                    return this.Collection[i].Value;
                }
            }

            throw new NoSuchKeyException("There is no such key.", nameof(key));
        }

        /// <summary>
        /// Determines whether the map contains the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if the map contains the key; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasKey(TKey key)
        {
            Contract.Requires(key != null);

            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determines whether the map contains the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the map contains the value; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasValue(TValue value)
        {
            Contract.Requires(value != null);

            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the size of the collection.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <exception cref="NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Size
        public override int Size()
        {
            throw new NotImplementedException();
        }

        public class MapItem : IMapItem<TKey, TValue>
        {
            public TKey Key { get; set; }

            public TValue Value { get; set; }

            public override string ToString() => $"{this.Key} -> {this.Value}";
        }
    }
}