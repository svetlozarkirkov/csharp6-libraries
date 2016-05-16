namespace ML.Map.Core.Contracts
{
    public interface IMap<TKey, TValue>
    {
        void Add(TKey key, TValue value);

        TValue Retrieve(TKey key);

        bool HasKey(TKey key);

        bool HasValue(TValue value);

        int Size();
    }
}