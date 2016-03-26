namespace Collections.Stack.ExceptionHandling.Core.Concrete
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class StackIndexOutOfRangeException : ArgumentOutOfRangeException
    {
        internal StackIndexOutOfRangeException()
        {
        }

        internal StackIndexOutOfRangeException(string paramName) : base(paramName)
        {
        }

        internal StackIndexOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        internal StackIndexOutOfRangeException(string paramName, string message)
            : base(paramName, message)
        {
        }

        internal StackIndexOutOfRangeException
            (string paramName, object actualValue, string message)
            : base(paramName, actualValue, message)
        {
        }

        protected StackIndexOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}