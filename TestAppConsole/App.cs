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
            //var stack = new Stack<object>();
            //var watch = Stopwatch.StartNew();
            //for (var i = 0; i < 9999999; i++)
            //{
            //    stack.Push(new object());
            //}
            //watch.Stop();
            //Console.WriteLine("{0}ms", watch.ElapsedMilliseconds);

            //var set = new LinkedSet<object>();
            //watch = Stopwatch.StartNew();
            //for (var i = 0; i < 9999999; i++)
            //{
            //    set.Add(new object());
            //}
            //watch.Stop();
            //Console.WriteLine("{0}ms", watch.ElapsedMilliseconds);

            var indexedStack = new IndexedStack<object>();
            for (int i = 0; i < 10; i++)
            {
                indexedStack.Push(i);
            }
            Console.WriteLine(indexedStack[2]);
            Console.WriteLine(indexedStack[-2]);
        }
    }
}