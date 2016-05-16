namespace ML.Set.Core.Base
{
    using ML.Set.Core.Contracts;

    public abstract class ArraySetBase<T> : ISet<T>
    {
        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public int Size()
        {
            throw new System.NotImplementedException();
        }
    }
}