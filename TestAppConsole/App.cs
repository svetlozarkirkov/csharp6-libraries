namespace TestAppConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Collections.Map.Core.Concrete;

    internal class App
    {
        private static void Main()
        {
            const int itemsToInsert = 10000000;

            var dictionary = new Dictionary<object, object>(itemsToInsert);
            var map = new Map<object, object>();

            var watch = new Stopwatch();

            watch.Start();
            Parallel.For(0, itemsToInsert, i => dictionary.Add(new object(), new object()));
            Console.WriteLine("{0}", watch.Elapsed);

            watch.Restart();
            Parallel.For(0, itemsToInsert, i => map.Store(new object(), new object()));
            watch.Stop();
            Console.WriteLine("{0}", watch.Elapsed);
        }
    }
}