namespace Console.Demo
{
    using System;
    using System.Diagnostics;
    using ML.Stack.Core.Concrete;

    /// <summary>
    /// Class App.
    /// </summary>
    internal class App
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            const int Items = 10000000;

            var stack = new ArrayStack<string>();

            var watch = new Stopwatch();
            watch.Start();

            for (var i = 0; i < Items; i++)
            {
                stack.Push("Hello World!");
            }

            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }
    }
}