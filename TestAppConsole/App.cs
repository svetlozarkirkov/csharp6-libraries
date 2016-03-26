namespace TestAppConsole
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using Collections.Set.Core.Concrete;
    using Collections.Stack.Core.Concrete;

    internal class App
    {
        /// <exception cref="IOException">An I/O error occurred. </exception>
        /// <exception cref="ArgumentNullException"><paramref /> is null. </exception>
        /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
        internal static void Main()
        {
            var testObject = new object();

            var stack = new Stack<object>();
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < 100000000; i++)
            {
                stack.Push(testObject);
            }
            watch.Stop();
            Console.WriteLine("{0}ms", watch.ElapsedMilliseconds);

            var set = new SingleLinkSet<object>();
            watch = Stopwatch.StartNew();
            for (var i = 0; i < 100000000; i++)
            {
                set.Add(testObject);
            }
            watch.Stop();
            Console.WriteLine("{0}ms", watch.ElapsedMilliseconds);
        }
    }
}