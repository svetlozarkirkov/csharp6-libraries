namespace TestAppConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using ConsoleDump;
    using Collections.Map.Core.Concrete;
    using Collections.Map.Core.Interface;

    internal class App
    {
        private static void Main()
        {
            const int itemsToInsert = 1000000;
            var watch = new Stopwatch();

            var dictionary = new Dictionary<object, object>(itemsToInsert);
            var map = new NodeMap<object, object>();

            watch.Start();
            for (var i = 0; i < itemsToInsert; i++)
            {
                dictionary.Add(i, i);
            }
            foreach (var item in dictionary)
            {
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            watch.Restart();
            for (var i = 0; i < itemsToInsert; i++)
            {
                map.Store(i, i);
            }
            foreach (var item in map)
            {
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            Console.ReadKey();
        }
    }
}