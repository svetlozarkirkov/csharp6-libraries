namespace ML.Stack.Tests.Core.Concrete
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;
    using ML.Stack.Core.Concrete;
    using ML.Stack.Core.Exceptions;

    [TestFixture]
    public class PermanentArrayStackTests
    {
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void WhenStackIsCreated_IfValidCapacityGiven_ShouldNotThrowException
            ([Values(1, 10, 100, 10000, int.MaxValue)] int capacity)
        {
            // Arrange
            Action act = () =>
            {
                var stack = new PermanentArrayStack<object>(capacity);
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
                var stack = new PermanentArrayStack<object>(capacity);
            };

            // Act Assert
            act.ShouldThrowExactly<InvalidStackCapacityException>();
        }

        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void WhenItemIsPushed_IfCurrentCapacityIsReached_ShouldThrowException
            ([Values(1, 10, 100, 1000, 10000)] int capacity)
        {
            // Arrange
            var stub = new PermanentArrayStack<string>(capacity);
            for (var i = 0; i < capacity; i++)
            {
                stub.Push("Hello World!");
            }

            // Act
            Action act = () => stub.Push("Hello World!");

            // Assert
            act.ShouldThrowExactly<FullStackException>();
        }
    }
}