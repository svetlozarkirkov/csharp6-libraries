namespace Collections.Stack.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// </summary>
    [Serializable]
    public class EmptyStackException : Exception
    {
        /// <summary>
        /// </summary>
        public EmptyStackException()
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        public EmptyStackException(string message)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected EmptyStackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}