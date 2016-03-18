namespace Collections.Stack.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception class for full Stack.
    /// </summary>
    [Serializable]
    public class FullStackException : Exception
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public FullStackException()
        {
        }

        /// <summary>
        /// Constructor with message.
        /// </summary>
        /// <param name="message"></param>
        public FullStackException(string message)
        {
        }

        /// <summary>
        /// Constructor with message and inner Exception.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public FullStackException(string message, Exception innerException)
        {
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">SerializationInfo</param>
        /// <param name="context">StreamingContext</param>
        /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected FullStackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}