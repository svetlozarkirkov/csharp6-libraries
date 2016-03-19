namespace TestAppConsole
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using Collections.Stack.Concrete;

    internal class App
    {
        /// <exception cref="IOException">An I/O error occurred. </exception>
        /// <exception cref="ArgumentNullException"><paramref /> is null. </exception>
        /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
        internal static void Main()
        {
            var permanentStack = new PermanentStack<object>(2);
            permanentStack.Push(new Stack<object>());

            var watch = Stopwatch.StartNew();

            for (var i = 0; i < 10; i++)
            {
                permanentStack.Push(new object());
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("{0}ms", elapsedMs);

            var methods = Utilities.ReflectionUtils.GetAllMethods(permanentStack.GetType());
            var properties = Utilities.ReflectionUtils.GetAllProperties(permanentStack.GetType());
            var constructors = Utilities.ReflectionUtils.GetAllConstructors(permanentStack.GetType());
            var fields = Utilities.ReflectionUtils.GetAllFields(permanentStack.GetType());
        }
    }
}