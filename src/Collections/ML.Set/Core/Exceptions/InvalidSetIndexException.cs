namespace ML.Set.Core.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class InvalidSetIndexException.
    /// </summary>
    /// <seealso cref="ArgumentOutOfRangeException" />
    [Serializable]
    public class InvalidSetIndexException : ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSetIndexException"/> class.
        /// </summary>
        public InvalidSetIndexException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSetIndexException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that causes this exception.</param>
        public InvalidSetIndexException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSetIndexException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public InvalidSetIndexException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSetIndexException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">The message that describes the error.</param>
        public InvalidSetIndexException(string paramName, string message)
            : base(paramName, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSetIndexException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="actualValue">The value of the argument that causes this exception.</param>
        /// <param name="message">The message that describes the error.</param>
        public InvalidSetIndexException(string paramName, object actualValue, string message)
            : base(paramName, actualValue, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSetIndexException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">An object that describes the source or destination of the serialized data.</param>
        protected InvalidSetIndexException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}