namespace Collections.Tests.Stack.Core.Concrete
{
    using System;
    using System.Reflection;

    using Collections.Core.Exceptions;

    using FluentAssertions;
    using Moq;
    using NUnit.Framework;

    using Collections.Stack.Core.Concrete;

    [TestFixture]
    public class ArrayStackTests
    {
        /// <summary>
        /// The default parameterless constructor should not throw the specific exception.
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void DefaultParameterlessConstructor_ShouldNotThrowException()
        {
            // Arrange
            var mock = new Mock<ArrayStack<object>>() {CallBase = true};
            object placeholder = null;
            Action act = () => { placeholder = mock.Object; };

            // Act Assert
            act.ShouldNotThrow<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// Constructor with capacity - if invalid capacity is given - throw exception
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void ConstructorWithCapacity_InvalidCapacity_ShouldThrowException(
            [Values(0, -1, -100, -1000, int.MinValue)] int capacity)
        {
            // Arrange
            var mock = new Mock<ArrayStack<object>>(capacity) {CallBase = true};
            object placeholder = null;
            Action act = () => { placeholder = mock.Object; };

            // Act Assert
            act.ShouldThrowExactly<TargetInvocationException>()
                .WithInnerExceptionExactly<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// Constructor with capacity - if valid capacity is given - exception should not be thrown
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void ConstructorWithCapacity_ValidCapacity_ShouldNotThrowException(
            [Values(1, 100, 1000, 100000, int.MaxValue)] int capacity)
        {
            // Arrange
            var mock = new Mock<ArrayStack<object>>(capacity) {CallBase = true};
            object placeholder = null;
            Action act = () => { placeholder = mock.Object; };

            // Act Assert
            act.ShouldNotThrow<InvalidCollectionCapacityException>();
        }
    }
}