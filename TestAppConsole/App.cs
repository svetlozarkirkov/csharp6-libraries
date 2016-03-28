namespace TestAppConsole
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using Collections.Set.Core.Concrete;
    using Collections.Stack.Core.Concrete;

    internal class App
    {
        /// <exception cref="IOException">An I/O error occurred. </exception>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null. </exception>
        /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
        private static void Main()
        {
            var testObject = new object();

            var defaultStack = new Stack<object>();
            var watch = new Stopwatch();
            watch.Start();
            for (var i = 0; i < 100000000; i++)
            {
                defaultStack.Push(testObject);
            }
            watch.Stop();
            var defaultStackTime = watch.ElapsedMilliseconds;

            var permanentStack = new PermanentStack<object>(100000000);
            watch.Restart();
            for (var i = 0; i < 100000000; i++)
            {
                permanentStack.Push(testObject);
            }
            watch.Stop();
            var permanentStackTime = watch.ElapsedMilliseconds;

            var singleLinkedSet = new SingleLinkSet<object>();
            watch.Restart();
            for (var i = 0; i < 100000000; i++)
            {
                singleLinkedSet.Add(testObject);
            }
            watch.Stop();
            var singleLinkedSetTime = watch.ElapsedMilliseconds;

            PrintObjectBenchData(
                defaultStack,
                defaultStackTime,
                GetObjectSize(defaultStack));

            PrintObjectBenchData(
                permanentStack,
                permanentStackTime,
                GetObjectSize(permanentStack));

            PrintObjectBenchData(
                singleLinkedSet,
                singleLinkedSetTime,
                GetObjectSize(singleLinkedSet));
        }

        private static void PrintObjectBenchData(object item, long time, long memory)
        {
            Console.WriteLine("{0} = [ Time: {1}ms ] [ Object size: {2} ]",
                item.GetType().Name,
                time,
                memory);
        }

        private static long GetObjectSize(object item)
        {
            long size = 0;
            using (Stream s = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(s, item);
                size = s.Length;
            }
            return size;
        }
    }
}