﻿namespace ML.Stack.Core.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class EmptyStackException.
    /// </summary>
    /// <seealso cref="System.InvalidOperationException" />
    [Serializable]
    public class EmptyStackException : InvalidOperationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyStackException"/> class.
        /// </summary>
        public EmptyStackException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyStackException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public EmptyStackException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyStackException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.</param>
        public EmptyStackException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyStackException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected EmptyStackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}