namespace Collections.Tests.Stack.Core.Base
{
    using System;

    using Collections.Core.Exceptions;

    using FluentAssertions;
    using Moq;
    using NUnit.Framework;

    using Collections.Stack.Core.Base;
    using Collections.Stack.Exceptions;

    [TestFixture]
    public class ArrayStackBaseTests
    {
        /// <summary>
        /// When the stack is initialized
        /// The size must be '0'
        /// </summary>
        [Test]
        public void WhenEmptyStack_SizeMustBeZero()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() { CallBase = true };

            // Act Assert
            mock.Object.Size().Should().Be(0);
        }

        /// <summary>
        /// When the stack is initialized
        /// "Pop" method should throw "Empty Collection Exception"
        /// </summary>
        /// <exception cref="EmptyCollectionException">The collection is empty.</exception>
        [Test]
        public void EmptyStack_Pop_ShouldThrowException()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() {CallBase = true};

            // Act Assert
            mock.Invoking(s => s.Object.Pop()).ShouldThrowExactly<EmptyCollectionException>();
        }

        /// <summary>
        /// When the stack is initialized
        /// "Peek" method should throw "EmptyStackException"
        /// </summary>
        /// <exception cref="EmptyCollectionException">The collection is empty.</exception>
        [Test]
        public void EmptyStack_Peek_ShouldThrowException()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() { CallBase = true };

            // Act Assert
            mock.Invoking(s => s.Object.Peek()).ShouldThrowExactly<EmptyCollectionException>();
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
            var mock = new Mock<ArrayStackBase<object>>() {CallBase = true};

            // Act
            mock.Object.Push(It.IsAny<object>());

            // Assert
            mock.Object.Size().Should().Be(1);
        }

        /// <summary>
        /// When the stack is at full capacity and an item is pushed
        /// There should be no FullStackException thrown
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void StackAtFullCapacity_WhenItemIsPushed_ShouldNotThrowException()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>(1) { CallBase = true };
            mock.Object.Push(It.IsAny<object>());

            // Act Assert
            mock
                .Invoking(s => s.Object.Push(It.IsAny<object>()))
                .ShouldNotThrow<FullStackException>();
        }

        /// <summary>
        /// When the stack is empty and an item is pushed
        /// The item returned with "Pop" should be the same as the pushed one
        /// </summary>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PopShouldReturnTheSameItem()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() { CallBase = true };
            var item = It.IsAny<object>();
            mock.Object.Push(item);

            // Act
            var poppedItem = mock.Object.Pop();

            // Assert
            Assert.AreSame(item, poppedItem, "The popped item was not the same.");
        }

        /// <summary>
        /// When the stack is empty, an item is pushed and then "Pop" is invoked
        /// The size of the stack must be zero;
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PopInvoked_SizeMustBeZero()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() { CallBase = true };
            mock.Object.Push(It.IsAny<object>());
            mock.Object.Pop();

            // Act Assert
            mock.Object.Size().Should().Be(0);
        }

        /// <summary>
        /// When the stack is empty, an item is pushed and "Peek" is invoked
        /// The returned item must be the same as the pushed one
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PeekInvoked_ShouldReturnTheSameItem()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() { CallBase = true };
            var item = It.IsAny<object>();
            mock.Object.Push(item);

            // Act
            var peekedItem = mock.Object.Peek();

            // Assert
            Assert.AreSame(item, peekedItem, "The peeked item was not the same.");
        }

        /// <summary>
        /// When the stack is empty, item is pushed and "Peek" is invoked
        /// The size of the stack must be one.
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PeekInvoked_SizeMustBeOne()
        {
            // Arrange
            var mock = new Mock<ArrayStackBase<object>>() { CallBase = true };
            mock.Object.Push(It.IsAny<object>());
            mock.Object.Peek();

            // Act Assert
            mock.Object.Size().Should().Be(1);
        }
    }
}