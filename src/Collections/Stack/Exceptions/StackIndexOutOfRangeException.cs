namespace Collections.Stack.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class StackIndexOutOfRangeException.
    /// </summary>
    /// <seealso cref="System.ArgumentOutOfRangeException" />
    [Serializable]
    public class StackIndexOutOfRangeException : ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackIndexOutOfRangeException"/> class.
        /// </summary>
        internal StackIndexOutOfRangeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackIndexOutOfRangeException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that causes this exception.</param>
        internal StackIndexOutOfRangeException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackIndexOutOfRangeException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        internal StackIndexOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackIndexOutOfRangeException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">The message that describes the error.</param>
        internal StackIndexOutOfRangeException(string paramName, string message)
            : base(paramName, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackIndexOutOfRangeException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="actualValue">The value of the argument that causes this exception.</param>
        /// <param name="message">The message that describes the error.</param>
        internal StackIndexOutOfRangeException
            (string paramName, object actualValue, string message)
            : base(paramName, actualValue, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackIndexOutOfRangeException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">An object that describes the source or destination of the serialized data.</param>
        protected StackIndexOutOfRangeException
            (SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}