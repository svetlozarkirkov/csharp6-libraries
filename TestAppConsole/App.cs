namespace TestAppConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using ConsoleDump;
    using Collections.Map.Core.Concrete;
    using Collections.Map.Core.Interface;

    internal class App
    {
        private static void Main()
        {
            const int itemsToInsert = 1000000;
            var dictionaryTicks = new List<long>();
            var nodeMapTicks = new List<long>();

            for (var index = 0; index < 100; index++)
            {
                var watch = new Stopwatch();
                var dictionary = new Dictionary<int, int>(itemsToInsert);
                var map = new NodeMap<int, int>();

                watch.Start();
                for (var i = 0; i < itemsToInsert; i++)
                {
                    dictionary.Add(i, i);
                }
                watch.Stop();
                dictionaryTicks.Add(watch.ElapsedTicks);

                watch.Restart();
                for (var i = 0; i < itemsToInsert; i++)
                {
                    map.Store(i, i);
                }
                watch.Stop();
                nodeMapTicks.Add(watch.ElapsedTicks);
            }

            Console.WriteLine("Dictionary average time: {0}", dictionaryTicks.Average());
            Console.WriteLine("NodeMap average time: {0}", nodeMapTicks.Average());

            Console.ReadKey();

            var nodeMap = new NodeMap<int, int>();
            for (var i = 0; i < 20; i++)
            {
                nodeMap.Store(i, i);
            }

            foreach (IMapItem<int, int> item in nodeMap)
            {
                Console.WriteLine("{0} : {1} => {2}",
                    item.GetType().Name,
                    item.Key,
                    item.Value);
            }
        }
    }
}