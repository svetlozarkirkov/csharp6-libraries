namespace Logging.Core.Contracts
{
    using Logging.LogLevel.Contracts;
    using Logging.LogOutput.Contracts;
    using Logging.LogSchema.Contracts;

    /// <summary>
    /// Interface ILog
    /// </summary>
    public interface ILog
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
        ILogOutput LoggerOutput { get; }

        /// <summary>
        /// Gets the logger schema.
        /// </summary>
        /// <value>The logger schema.</value>
        ILogSchema LoggerSchema { get; }
    }
}