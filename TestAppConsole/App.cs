namespace TestAppConsole
{
    using System;
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

            var anonymousNode = new SingleLinkedSetAnonymousNode<object>();
            watch.Start();
            Parallel.For(0, 20000000, i => anonymousNode.Add(testObject));
            watch.Stop();
            var anonymousNodeTime = watch.ElapsedMilliseconds;

            var nestedNode = new SingleLinkedSetNestedNode<object>();
            watch.Restart();
            Parallel.For(0, 20000000, i => nestedNode.Add(testObject));
            watch.Stop();
            var nestedNodeTime = watch.ElapsedMilliseconds;

            PrintObjectBenchData(anonymousNode, anonymousNodeTime);
            PrintObjectBenchData(nestedNode, nestedNodeTime);
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