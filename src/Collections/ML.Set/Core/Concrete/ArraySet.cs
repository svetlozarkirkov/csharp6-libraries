namespace ML.Set.Core.Concrete
{
    using ML.Set.Core.Base;

    public class ArraySet<T> : ArraySetBase<T>
    {
        public ArraySet()
        {
        }

        public ArraySet(int capacity) : base(capacity)
        {
        }
    }
}