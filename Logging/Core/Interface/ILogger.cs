namespace Logging.Core.Interface
{
    using Logging.LogLevel.Interface;
    using Logging.LogOutput.Interface;
    using Logging.LogSchema.Interface;

    /// <summary>
    /// Interface ILogger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Gets the log level.
        /// </summary>
        /// <value>The log level.</value>
        ILogLevel LogLevel { get; }

        /// <summary>
        /// Gets the logger output.
        /// </summary>
        /// <value>The logger output.</value>
        ILoggerOutput LoggerOutput { get; }

        /// <summary>
        /// Gets the logger schema.
        /// </summary>
        /// <value>The logger schema.</value>
        ILoggerSchema LoggerSchema { get; }
    }
}