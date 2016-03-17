namespace TestAppConsole
{
    using System;
    using System.Diagnostics;
    using Collections.Stack.Concrete;

    internal class App
    {
        internal static void Main()
        {
            var stack = new Stack<string>();
            var watch = Stopwatch.StartNew();

            for (int i = 0; i < 99999999; i++)
            {
                stack.Push("String");
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("{0}ms", elapsedMs);
        }
    }
}