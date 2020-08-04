namespace ML.Stack.Tests.Core.Concrete
{
    using System;
    using FluentAssertions;
    using ML.Stack.Core.Concrete;
    using ML.Stack.Core.Exceptions;
    using NUnit.Framework;

    /// <summary>
    /// The array stack tests.
    /// </summary>
    [TestFixture]
    public class ArrayStackTests
    {
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenStackIsCreated_IfNoCapacityGiven_ShouldNotThrowException()
        {
            // Arrange
            Action act = () =>
            {
                var stack = new ArrayStack<object>();
            };

            // Act Assert
            act.ShouldNotThrow<InvalidStackCapacityException>();
        }

        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenStackIsCreated_IfInvalidCapacityGiven_ShouldThrowException
            ([Values(0, -1, -100, -1000, -10000)] int capacity)
        {
            // Arrange
            Action act = () =>
            {
                var stack = new ArrayStack<object>(capacity);
            };

            // Act Assert
            act.ShouldThrowExactly<InvalidStackCapacityException>();
        }

        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenStackIsCreated_IfValidCapacityGiven_ShouldNotThrowException
            ([Values(1, 100, 1000, 10000, int.MaxValue)] int capacity)
        {
            // Arrange
            Action act = () =>
            {
                var stack = new ArrayStack<object>(capacity);
            };

            // Act Assert
            act.ShouldNotThrow<InvalidStackCapacityException>();
        }
    }
}