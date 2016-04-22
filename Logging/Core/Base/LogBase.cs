namespace Logging.Core.Base
{
    using Logging.Core.Contracts;
    using Logging.LogLevel.Contracts;
    using Logging.LogOutput.Contracts;
    using Logging.LogSchema.Contracts;

    /// <summary>
    /// Class LogBase.
    /// </summary>
    /// <seealso cref="ILog" />
    public abstract class LogBase : ILog
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
        public ILogOutput LoggerOutput { get; }

        /// <summary>
        /// Gets the logger schema.
        /// </summary>
        /// <value>The logger schema.</value>
        public ILogSchema LoggerSchema { get; }
    }
}