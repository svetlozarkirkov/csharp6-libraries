namespace Logging.Core.Base
{
    using Common.Patterns.Singleton;
    using Logging.Core.Contracts;
    using Logging.LogLevel.Contracts;
    using Logging.LogOutput.Contracts;
    using Logging.LogSchema.Contracts;

    /// <summary>
    /// Class SingletonStandardLogBase.
    /// </summary>
    /// <seealso cref="Common.Patterns.Singleton.AbstractSingleton{SingletonStandardLogBase}" />
    /// <seealso cref="ILog" />
    /// TODO Edit XML Comment Template for SingletonStandardLogBase
    public class SingletonStandardLogBase : AbstractSingleton<SingletonStandardLogBase>, ILog
    {
        /// <summary>
        /// Gets the log level.
        /// </summary>
        /// <value>The log level.</value>
        /// TODO Edit XML Comment Template for LogLevel
        public ILogLevel LogLevel { get; }

        /// <summary>
        /// Gets the logger output.
        /// </summary>
        /// <value>The logger output.</value>
        /// TODO Edit XML Comment Template for LogOutput
        public ILogOutput LogOutput { get; }

        /// <summary>
        /// Gets the logger schema.
        /// </summary>
        /// <value>The logger schema.</value>
        /// TODO Edit XML Comment Template for LogSchema
        public ILogSchema LogSchema { get; }
    }
}