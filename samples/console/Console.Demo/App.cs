namespace Console.Demo
{
    using ML.Stack.Core.Concrete;

    /// <summary>
    /// Class App.
    /// </summary>
    internal class App
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            var stack = new ArrayStack<string>(int.MaxValue);
        }
    }
}