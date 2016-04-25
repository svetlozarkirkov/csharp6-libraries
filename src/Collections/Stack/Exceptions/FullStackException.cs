namespace Collections.Stack.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class FullStackException.
    /// </summary>
    /// <seealso cref="System.InvalidOperationException" />
    [Serializable]
    public class FullStackException : InvalidOperationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullStackException"/> class.
        /// </summary>
        internal FullStackException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullStackException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        internal FullStackException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullStackException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.</param>
        internal FullStackException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullStackException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected FullStackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}