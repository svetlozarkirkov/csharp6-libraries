﻿namespace Collections.Stack.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception class for empty Stack.
    /// </summary>
    [Serializable]
    public class EmptyStackException : Exception
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public EmptyStackException()
        {
        }

        /// <summary>
        /// Constructor with message.
        /// </summary>
        /// <param name="message"></param>
        public EmptyStackException(string message)
        {
        }

        /// <summary>
        /// Constructor with message and inner exception.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner Exception</param>
        public EmptyStackException(string message, Exception innerException)
        {
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">SerializationInfo</param>
        /// <param name="context">StreamingContext</param>
        /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected EmptyStackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}