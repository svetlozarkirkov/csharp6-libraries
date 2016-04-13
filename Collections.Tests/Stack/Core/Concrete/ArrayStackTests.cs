namespace Collections.Tests.Stack.Core.Concrete
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;
    using Collections.Core.ExceptionHandling.Concrete;
    using Collections.Stack.Core.Concrete;

    [TestFixture]
    public class ArrayStackTests
    {
        /// <summary>
        /// The default parameterless constructor should not throw the specific exception.
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void DefaultParameterlessConstructor_ShouldNotThrowException()
        {
            // Arrange
            Action act = () => new ArrayStack<object>();

            // Act Assert
            act.ShouldNotThrow<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// Constructor with capacity - if invalid capacity is given - throw exception
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void ConstructorWithCapacity_InvalidCapacity_ShouldThrowException(
            [Values(0, -1, -100, -1000, int.MinValue)] int capacity)
        {
            // Arrange
            Action act = () => new ArrayStack<object>(capacity);

            // Act Assert
            act.ShouldThrowExactly<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// Constructor with capacity - if valid capacity is given - exception should not be thrown
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void ConstructorWithCapacity_ValidCapacity_ShouldNotThrowException(
            [Values(1, 100, 1000, 100000, int.MaxValue)] int capacity)
        {
            // Arrange
            Action act = () => new ArrayStack<object>(capacity);

            // Act Assert
            act.ShouldNotThrow<InvalidCollectionCapacityException>();
        }
    }
}