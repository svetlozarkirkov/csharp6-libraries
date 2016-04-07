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
        /// When the stack is empty and an item is pushed - the size after must be '1'
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        [Test]
        public void EmptyStack_WhenItemIsPushedIntoStack_SizeMustBeOne()
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