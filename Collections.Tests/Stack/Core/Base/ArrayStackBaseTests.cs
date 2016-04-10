namespace Collections.Tests.Stack.Core.Base
{
    using System;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Core.Base;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    [TestFixture]
    public class ArrayStackBaseTests
    {
        /// <summary>
        /// When the stack is initialized with an invalid capacity
        /// Should throw "InvalidCapacityGivenException"
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void StackIsInitialized_InvalidCapacityGiven_ShouldThrowException()
        {
        }

        /// <summary>
        /// When the stack is initialized
        /// The size must be '0'
        /// </summary>
        [Test]
        public void WhenEmptyStack_SizeMustBeZero()
        {
            // Act
            var mock = new Mock<ArrayStackBase<object>> { CallBase = true };

            // Assert
            mock.Object.Size().Should().Be(0);
        }

        /// <summary>
        /// When the stack is initialized
        /// "Pop" method should throw "EmptyStackException"
        /// </summary>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        [Test]
        public void EmptyStack_Pop_ShouldThrowException()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>> { CallBase = true };

            // Act Assert
            mock.Object.Invoking(c => c.Pop()).ShouldThrow<EmptyStackException>();
        }

        /// <summary>
        /// When the stack is initialized
        /// "Peek" method should throw "EmptyStackException"
        /// </summary>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        [Test]
        public void EmptyStack_Peek_ShouldThrowException()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>> { CallBase = true };

            // Act Assert
            mock.Object.Invoking(c => c.Peek()).ShouldThrow<EmptyStackException>();
        }

        /// <summary>
        /// When the stack is initialized and an item is pushed
        /// The size of the stack must be '1'
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void EmptyStack_WhenItemIsPushed_SizeMustBeOne()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>> {CallBase = true};

            // Act
            mock.Object.Push(It.IsAny<object>());

            // Assert
            mock.Object.Size().Should().Be(1);
        }
    }
}