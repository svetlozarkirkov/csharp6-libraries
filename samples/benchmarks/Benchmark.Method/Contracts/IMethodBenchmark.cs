namespace Benchmark.Method.Contracts
{
    using System;

    /// <summary>
    /// Interface IMethodBenchmark
    /// </summary>
    /// TODO Edit XML Comment Template for IMethodBenchmark
    public interface IMethodBenchmark
    {
        /// <summary>
        /// Gets the elapsed time.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="iterations">The iterations.</param>
        /// <returns>TimeSpan.</returns>
        /// TODO Edit XML Comment Template for GetElapsedTime
        TimeSpan GetElapsedTime(Action method, ulong iterations);
    }
}