namespace Benchmark.Method.Base
{
    using System;
    using System.Diagnostics;
    using Benchmark.Method.Contracts;

    /// <summary>
    /// Class MethodBenchmarkBase.
    /// </summary>
    /// <seealso cref="IMethodBenchmark" />
    /// TODO Edit XML Comment Template for MethodBenchmarkBase
    public abstract class MethodBenchmarkBase : IMethodBenchmark
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MethodBenchmarkBase"/> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        protected MethodBenchmarkBase()
        {
            this.StopWatch = new Stopwatch();
        }

        /// <summary>
        /// Gets the stop watch.
        /// </summary>
        /// <value>The stop watch.</value>
        /// TODO Edit XML Comment Template for StopWatch
        protected Stopwatch StopWatch { get; }

        /// <summary>
        /// Gets the elapsed time.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="iterations">The iterations.</param>
        /// <returns>TimeSpan.</returns>
        /// TODO Edit XML Comment Template for GetElapsedTime
        public TimeSpan GetElapsedTime(Action method, ulong iterations)
        {
            this.StopWatch.Restart();
            for (ulong i = 0; i < iterations; i++)
            {
                method.Invoke();
            }
            this.StopWatch.Stop();

            return this.StopWatch.Elapsed;
        }
    }
}