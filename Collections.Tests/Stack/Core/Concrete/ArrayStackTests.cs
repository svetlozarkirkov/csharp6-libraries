﻿namespace Collections.Tests.Stack.Core.Concrete
{
    using System;

    using Collections.Core.ExceptionHandling.Concrete;

    using FluentAssertions;
    using NUnit.Framework;
    using Collections.Stack.Core.Concrete;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

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
            Action act = () => new ArrayStack<object>();

            // Act Assert
            act.ShouldNotThrow<InvalidStackCapacityGivenException>();
        }

        /// <summary>
        /// Constructor with capacity - if invalid capacity is given (0) - throw exception
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void ConstructorWithCapacity_InvalidCapacity_ShouldThrowException()
        {
            // Arrange
            Action act = () => new ArrayStack<object>(0);

            // Act Assert
            act.ShouldThrowExactly<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// Constructor with capacity - if valid capacity is given (1) - exception should not be thrown
        /// </summary>
        /// <exception cref="InvalidStackCapacityGivenException">Capacity is less than or equal to zero.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void ConstructorWithCapacity_ValidCapacity_ShouldNotThrowException()
        {
            // Arrange
            Action act = () => new ArrayStack<object>(1);

            // Act Assert
            act.ShouldNotThrow<InvalidStackCapacityGivenException>();
        }
    }
}