namespace Collections.Tests.Stack.Core.Base
{
    using System;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Core.Base;

    [TestFixture]
    public class ArrayStackBaseTests
    {
        /// <summary>
        /// When the stack is initialized - the size must be '0'
        /// </summary>
        [Test]
        public void StackIsInitialized_SizeMustBeZero()
        {
            // Act
            var classMock = new Mock<ArrayStackBase<object>> {CallBase = true};

            // Assert
            classMock.Object.Size().Should().Be(0);
        }

        /// <summary>
        /// When the stack is initialized and an item is pushed - the size after must be '1'
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The argument is null.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void StackIsInitialized_ItemIsPushed_SizeMustBeOne()
        {
            // Arrange
            var classMock = new Mock<ArrayStackBase<object>> {CallBase = true};

            // Act
            classMock.Object.Push(It.IsAny<object>());

            // Assert
            classMock.Object.Size().Should().Be(1);
        }
    }
}