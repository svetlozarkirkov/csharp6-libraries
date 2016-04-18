namespace Logging.Core.Base
{
    using Logging.Core.Contracts;
    using Logging.LogLevel.Contracts;
    using Logging.LogOutput.Contracts;
    using Logging.LogSchema.Contracts;

    /// <summary>
    /// Class LoggerBase.
    /// </summary>
    /// <seealso cref="ILogger" />
    public abstract class LoggerBase : ILogger
    {
        /// <summary>
        /// Gets the log level.
        /// </summary>
        /// <value>The log level.</value>
        public ILogLevel LogLevel { get; }

        /// <summary>
        /// Gets the logger output.
        /// </summary>
        /// <value>The logger output.</value>
        public ILoggerOutput LoggerOutput { get; }

        /// <summary>
        /// Gets the logger schema.
        /// </summary>
        /// <value>The logger schema.</value>
        public ILoggerSchema LoggerSchema { get; }
    }
}