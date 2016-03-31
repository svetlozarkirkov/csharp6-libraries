namespace Collections.Stack.Core.Interface
{
    using Collections.Injectors.Clear;
    using Collections.Injectors.Index;

    /// <summary>
    /// Interface IStandardStack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Collections.Stack.Core.Interface.IStack{T}" />
    /// <seealso cref="Collections.Injectors.Index.IIndexable{T}" />
    /// <seealso cref="Collections.Injectors.Clear.IClearable" />
    internal interface IStandardStack<T> : IStack<T>, IIndexable<T>, IClearable
    {
    }
}