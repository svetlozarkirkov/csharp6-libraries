namespace Console.Demo
{
    using System;
    using Collections.Map.Core.Base;

    internal class App
    {
        private static void Main()
        {
            var map = new ArrayMap<int, int>();
            map.Store(1,2);

            Console.WriteLine(map);
        }
    }
}