namespace ML.Set.Core.Contracts
{
    public interface ISet<T>
    {
        void Add(T item);

        void Remove(T item);

        void RemoveAt(int index);

        int Count();
    }
}