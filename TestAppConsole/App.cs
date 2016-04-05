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
            const int itemsToInsert = 10000000;
            var watch = new Stopwatch();

            var dictionary = new Dictionary<object, object>(itemsToInsert);
            var map = new NodeMap<object, object>();

            watch.Start();
            for (var i = 0; i < itemsToInsert; i++)
            {
                dictionary.Add(i, i);
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            watch.Restart();
            for (var i = 0; i < itemsToInsert; i++)
            {
                map.Store(i, i);
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            //foreach (IMapItem<object, object> item in map)
            //{
            //    Console.WriteLine("{0} => {1}", item.Key, item.Value);
            //}
        }
    }
}