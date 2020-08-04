// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMapPair.cs" company="">
//   
// </copyright>
// <summary>
//   Interface IMapPair
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ML.Map.Core.Contracts
{
    /// <summary>
    /// Interface IMapPair
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public interface IMapPair<TKey, TValue>
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The key.</value>
        TKey Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        TValue Value { get; set; }
    }
}