namespace Console.Demo
{
    using System;
    using Collections.Map.Core.Base;

    internal class App
    {
        private static void Main()
        {
            var map = new ArrayMap<string, int>();
            map.Store("one", 0);
            map.Store("two", 1);
            map.Store("three", 2);

            Console.WriteLine(map);
        }
    }
}