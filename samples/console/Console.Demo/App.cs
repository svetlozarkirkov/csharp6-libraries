namespace Console.Demo
{
    using System;
    using System.Collections.Generic;
    using Benchmark.Method.Concrete;
    using Collections.Map.Core.Base;
    using Collections.Stack.Core.Base;

    internal class App
    {
        private static void Main()
        {
            const int Iterations = 1000000;

            var map = new ArrayMap<object, object>();
            var stack = new ArrayStack<object>();
            var dictionary = new Dictionary<object, object>();

            var benchmark = new MethodBenchmark();

            var mapTime = benchmark.GetElapsedTime(
                () => map.Store(1, 1), Iterations);

            Console.WriteLine(mapTime);

            var stackTime = benchmark.GetElapsedTime(
                () => stack.Push(new object()), Iterations);

            Console.WriteLine(stackTime);

            var dictionaryTime = benchmark.GetElapsedTime(
                () => dictionary.Add(new object(), new object()), Iterations);

            Console.WriteLine(dictionaryTime);
        }
    }
}