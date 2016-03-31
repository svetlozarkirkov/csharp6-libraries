namespace Collections.Injectors.Index
{
    /// <summary>
    /// Interface IIndexable
    /// </summary>
    internal interface IIndexable<out T>
    {
        /// <summary>
        /// Gets the <see cref="System.Int32"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Int32.</returns>
        T this[int index] { get; }
    }
}