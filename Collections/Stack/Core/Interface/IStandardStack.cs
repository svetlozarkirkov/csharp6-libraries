namespace Collections.Stack.Core.Interface
{
    using Collections.Injectors.Clear;
    using Collections.Injectors.Index;

    /// <summary>
    /// Interface IStandardStack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Interface.IStack{T}" />
    /// <seealso cref="Injectors.Index.IIndexable{T}" />
    /// <seealso cref="IClearable" />
    public interface IStandardStack<T> : IStack<T>, IIndexable<T>, IClearable
    {
    }
}