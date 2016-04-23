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
    /// TODO Edit XML Comment Template for LogBase
    public abstract class LogBase : ILog
    {
        /// <summary>
        /// Gets the log level.
        /// </summary>
        /// <value>The log level.</value>
        public ILogLevel LogLevel { get; }

        /// <summary>
        /// Gets the log output.
        /// </summary>
        /// <value>The log output.</value>
        public ILogOutput LogOutput { get; }

        /// <summary>
        /// Gets the log schema.
        /// </summary>
        /// <value>The log schema.</value>
        public ILogSchema LogSchema { get; }
    }
}