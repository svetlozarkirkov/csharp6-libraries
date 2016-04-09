namespace TestAppConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Collections.Map.Core.Concrete;
    using Collections.Map.Core.Interface;
    using Collections.Stack.Core.Concrete;

    internal class App
    {
        private static void Main()
        {
            const int ItemsToInsert = 1000000;
            var dictionaryTicks = new List<long>();
            var nodeMapTicks = new List<long>();
            var arrayStackTicks = new List<long>();

            for (var index = 0; index < 100; index++)
            {
                var watch = new Stopwatch();

                watch.Start();
                var dictionary = new Dictionary<int, int>(ItemsToInsert);
                for (var i = 0; i < ItemsToInsert; i++)
                {
                    dictionary.Add(i, i);
                }
                watch.Stop();
                dictionaryTicks.Add(watch.ElapsedTicks);

                watch.Restart();
                var map = new NodeMap<int, int>();
                for (var i = 0; i < ItemsToInsert; i++)
                {
                    map.Store(i, i);
                }
                watch.Stop();
                nodeMapTicks.Add(watch.ElapsedTicks);

                watch.Restart();
                var stack = new ArrayStack<int>();
                for (var i = 0; i < ItemsToInsert; i++)
                {
                    stack.Push(i);
                }
                watch.Stop();
                arrayStackTicks.Add(watch.ElapsedTicks);
            }

            Console.WriteLine("Dictionary average ticks: {0}", dictionaryTicks.Average());
            Console.WriteLine("NodeMap average ticks: {0}", nodeMapTicks.Average());
            Console.WriteLine("ArrayStack average ticks: {0}", arrayStackTicks.Average());

            Console.ReadKey();

            var nodeMap = new NodeMap<int, int>();
            for (var i = 0; i < 10; i++)
            {
                nodeMap.Store(i, i);
            }

            foreach (IMapItem<int, int> item in nodeMap)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }
        }
    }
}