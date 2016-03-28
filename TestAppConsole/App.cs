namespace TestAppConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Threading.Tasks;
    using Collections.Set.Core.Concrete;
    using Collections.Stack.Core.Concrete;

    internal class App
    {
        /// <exception cref="IOException">An I/O error occurred. </exception>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null. </exception>
        /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
        private static void Main()
        {
            var watch = new Stopwatch();
            var testObject = new object();

            var defaultList = new List<object>(20000000);
            watch.Restart();
            Parallel.For(0, 20000000, i => defaultList.Add(testObject));
            watch.Stop();
            var defaultListTime = watch.ElapsedMilliseconds;

            var linkedList = new LinkedList<object>();
            watch.Restart();
            Parallel.For(0, 20000000, i => linkedList.AddLast(testObject));
            watch.Stop();
            var linkedListTime = watch.ElapsedMilliseconds;

            var nestedNode = new SingleLinkedSetNestedNode<object>();
            watch.Restart();
            Parallel.For(0, 20000000, i => nestedNode.Add(testObject));
            watch.Stop();
            var nestedNodeTime = watch.ElapsedMilliseconds;

            var standardStack = new StandardStack<object>(20000000);
            watch.Restart();
            Parallel.For(0, 20000000, i => standardStack.Push(testObject));
            watch.Stop();
            var standardStackTime = watch.ElapsedMilliseconds;

            PrintObjectBenchData(defaultList, defaultListTime);
            PrintObjectBenchData(linkedList, linkedListTime);
            PrintObjectBenchData(nestedNode, nestedNodeTime);
            PrintObjectBenchData(standardStack, standardStackTime);
        }

        private static void PrintObjectBenchData(object item, long time)
        {
            Console.WriteLine("{0} = [ Time: {1}ms ]",
                item.GetType().Name,
                time);
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