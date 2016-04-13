namespace Collections.Tests.Stack.Core.Base
{
    using System;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Collections.Core.ExceptionHandling.Concrete;
    using Collections.Stack.Core.Base;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    [TestFixture]
    public class ArrayStackBaseTests
    {
        /// <summary>
        /// Stub used for testing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <seealso cref="Collections.Stack.Core.Base.ArrayStackBase{T}" />
        private class ArrayStackBaseStub<T> : ArrayStackBase<T>
        {
            /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
            internal ArrayStackBaseStub() { }

            /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
            internal ArrayStackBaseStub(int capacity) : base(capacity) { }
        }

        /// <summary>
        /// When the stack is initialized
        /// The size must be '0'
        /// </summary>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void WhenEmptyStack_SizeMustBeZero()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();

            // Act Assert
            stub.Size().Should().Be(0);
        }

        /// <summary>
        /// When the stack is initialized
        /// "Pop" method should throw "EmptyStackException"
        /// </summary>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void EmptyStack_Pop_ShouldThrowException()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();

            // Act Assert
            stub.Invoking(s => s.Pop()).ShouldThrow<EmptyStackException>();
        }

        /// <summary>
        /// When the stack is initialized
        /// "Peek" method should throw "EmptyStackException"
        /// </summary>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void EmptyStack_Peek_ShouldThrowException()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();

            // Act Assert
            stub.Invoking(s => s.Peek()).ShouldThrow<EmptyStackException>();
        }

        /// <summary>
        /// When the stack is initialized and an item is pushed
        /// The size of the stack must be '1'
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void EmptyStack_WhenItemIsPushed_SizeMustBeOne()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();

            // Act
            stub.Push(It.IsAny<object>());

            // Assert
            stub.Size().Should().Be(1);
        }

        /// <summary>
        /// When the stack is at full capacity and an item is pushed
        /// There should be no FullStackException thrown
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void StackAtFullCapacity_WhenItemIsPushed_ShouldNotThrowException()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>(1);
            stub.Push(It.IsAny<object>());

            // Act Assert
            stub
                .Invoking(s => s.Push(It.IsAny<object>()))
                .ShouldNotThrow<FullStackException>();
        }

        /// <summary>
        /// When the stack is empty and an item is pushed
        /// The item returned with "Pop" should be the same as the pushed one
        /// </summary>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PopShouldReturnTheSameItem()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<string>();
            const string Item = "Pop test string";
            stub.Push(Item);

            // Act
            var poppedItem = stub.Pop();

            // Assert
            Assert.AreSame(Item, poppedItem, "The popped item was not the same.");
        }

        /// <summary>
        /// When the stack is empty, an item is pushed and then "Pop" is invoked
        /// The size of the stack must be zero;
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PopInvoked_SizeMustBeZero()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();
            stub.Push(It.IsAny<object>());
            stub.Pop();

            // Act Assert
            stub.Size().Should().Be(0);
        }

        /// <summary>
        /// When the stack is empty, an item is pushed and "Peek" is invoked
        /// The returned item must be the same as the pushed one
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PeekInvoked_ShouldReturnTheSameItem()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<string>();
            const string Item = "Peek test string";
            stub.Push(Item);

            // Act
            var peekedItem = stub.Peek();

            // Assert
            Assert.AreSame(Item, peekedItem, "The peeked item was not the same.");
        }

        /// <summary>
        /// When the stack is empty, item is pushed and "Peek" is invoked
        /// The size of the stack must be one.
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="EmptyStackException">The stack is empty.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_PeekInvoked_SizeMustBeOne()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();
            stub.Push(It.IsAny<object>());
            stub.Peek();

            // Act Assert
            stub.Size().Should().Be(1);
        }
    }
}