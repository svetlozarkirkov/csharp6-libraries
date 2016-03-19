namespace Collections.Set.Interface
{
    /// <summary>
    /// </summary>
    public interface ISet
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void Add<T>(T item);

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        void Remove(int index);

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void Remove<T>(T item);

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="index"></param>
        /// <returns></returns>
        T Get<T>(int index);
    }
}