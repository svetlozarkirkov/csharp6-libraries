namespace Common.Patterns.Singleton
{
    using System;
    using System.Reflection;

    public abstract class AbstractSingleton<T> where T : AbstractSingleton<T>
    {
        private static readonly Lazy<T> _instance;

        /// <summary>
        /// Default static constructor initializes Lazy constructor.
        /// </summary>
        static AbstractSingleton()
        {
            _instance = new Lazy<T>(
                () =>
                {
                    try
                    {
                        // Binding flags include private constructors.
                        var constructor =
                            typeof(T).GetConstructor(
                                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                null,
                                Type.EmptyTypes,
                                null);
                        return (T)constructor.Invoke(null);
                    }
                    // TODO: Elaborate the exception
                    catch (Exception)
                    {
                        throw new Exception();
                    }
                });
        }

        /// <summary>
        /// Get the singleton instance for the class.
        /// </summary>
        public static T Instance => _instance.Value;
    }
}