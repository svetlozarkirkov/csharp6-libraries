namespace Console.Demo
{
    using System;
    using System.Collections.Generic;
    using Benchmark.Method.Concrete;
    using Collections.Map.Core.Base;
    using Collections.Map.Core.Contracts;
    using Collections.Stack.Core.Base;

    internal class App
    {
        private static void Main()
        {
            const int Iterations = 10000000;

            var map = new ArrayMap<object, object>();
            var stack = new ArrayStack<IMapItem<object, object>>();
            var dictionary = new Dictionary<object, object>();

            var benchmark = new MethodBenchmark();

            var mapTime = benchmark.GetElapsedTime(
                () => map.Store(1, 1), Iterations);

            Console.WriteLine(mapTime);

            var stackTime = benchmark.GetElapsedTime(
                () => stack.Push(new ArrayMap<object, object>.MapItem()
                { Key = 1, Value = 2 }), Iterations);

            Console.WriteLine(stackTime);
            //Console.WriteLine(stack);

            var dictionaryTime = benchmark.GetElapsedTime(
                () => dictionary.Add(new object(), new object()), Iterations);

            Console.WriteLine(dictionaryTime);
        }
    }
}