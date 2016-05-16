namespace ML.Map.Core.Base
{
    using ML.Map.Core.Contracts;

    public abstract class ArrayMapBase<TKey, TValue> : IMap<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            throw new System.NotImplementedException();
        }

        public TValue Retrieve(TKey key)
        {
            throw new System.NotImplementedException();
        }

        public bool HasKey(TKey key)
        {
            throw new System.NotImplementedException();
        }

        public bool HasValue(TValue value)
        {
            throw new System.NotImplementedException();
        }

        public int Size()
        {
            throw new System.NotImplementedException();
        }
    }
}