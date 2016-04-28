namespace Collections.Map.Exceptions.ArrayMap
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class NoSuchKeyException.
    /// </summary>
    /// <seealso cref="System.ArgumentException" />
    /// TODO Edit XML Comment Template for NoSuchKeyException
    public class NoSuchKeyException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSuchKeyException"/> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public NoSuchKeyException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSuchKeyException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// TODO Edit XML Comment Template for #ctor
        public NoSuchKeyException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSuchKeyException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="paramName">The name of the parameter that caused the current exception.</param>
        /// TODO Edit XML Comment Template for #ctor
        public NoSuchKeyException(string message, string paramName)
            : base(message, paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSuchKeyException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        /// TODO Edit XML Comment Template for #ctor
        public NoSuchKeyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSuchKeyException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="paramName">The name of the parameter that caused the current exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        /// TODO Edit XML Comment Template for #ctor
        public NoSuchKeyException
            (string message, string paramName, Exception innerException)
            : base(message, paramName, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSuchKeyException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        /// TODO Edit XML Comment Template for #ctor
        protected NoSuchKeyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}