namespace ML.Stack.Tests.Core.Base
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;
    using ML.Stack.Core.Base;
    using ML.Stack.Core.Exceptions;

    [TestFixture]
    public class ArrayStackBaseTests
    {
        /// <summary>
        /// ArrayStackBase stub class used for unit-testing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <seealso cref="Stack.Core.Base.ArrayStackBase{T}" />
        private class ArrayStackBaseStub<T> : ArrayStackBase<T>
        {
            /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
            public ArrayStackBaseStub()
            {
            }

            /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
            public ArrayStackBaseStub(int stackCapacity) : base(stackCapacity)
            {
            }
        }

        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenStackIsCreated_IfNoCapacityGiven_ShouldNotThrowException()
        {
            // Arrange
            Action act = () =>
                {
                    var arrayStackBaseStub = new ArrayStackBaseStub<object>();
                };

            // Act Assert
            act.ShouldNotThrow<InvalidStackCapacityException>();
        }

        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenStackIsCreated_IfInvalidCapacityGiven_ShouldThrowException
            ([Values(-1, -100, -1000, -10000, int.MinValue)] int capacity)
        {
            // Arrange
            Action act = () =>
                {
                    var arrayStackBaseStub = new ArrayStackBaseStub<object>(capacity);
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
                    var stub = new ArrayStackBaseStub<object>(capacity);
                };

            // Act Assert
            act.ShouldNotThrow<InvalidStackCapacityException>();
        }

        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="EmptyStackException">Cannot pop from an empty stack.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void WhenItemIsPushed_IfPop_ShouldReturnSameItem
            ([Values(1, 32.1458758, "Hello World!", null)] object item)
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();
            stub.Push(item);

            // Act
            var poppedItem = stub.Pop();

            // Assert
            Assert.AreSame(item, poppedItem);
        }

        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void WhenItemIsPushed_IfCurrentCapacityIsReached_ShouldNotThrowException
            ([Values(1, 10, 100)] int capacity)
        {
            // Arrange
            var stub = new ArrayStackBaseStub<string>(capacity);
            for (var i = 0; i < capacity; i++)
            {
                stub.Push("Hello World!");
            }

            // Act
            Action act = () => stub.Push("Hello World!");

            // Assert
            act.ShouldNotThrow<IndexOutOfRangeException>();
        }

        /// <exception cref="EmptyStackException">Cannot peek into an empty stack.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenPeek_IfStackIsEmpty_ShouldThrowException()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();

            // Act
            Action act = () => stub.Peek();

            // Assert
            act.ShouldThrowExactly<EmptyStackException>();
        }

        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="EmptyStackException">Cannot peek into an empty stack.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void WhenItemIsPushed_IfPeek_ShouldReturnTheSameItem
            ([Values(2, -1232.412412, "Hello World")] object item)
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();
            stub.Push(item);

            // Act
            var peekedItem = stub.Peek();

            // Assert
            Assert.AreSame(item, peekedItem);
        }

        /// <exception cref="EmptyStackException">Cannot pop from an empty stack.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        [Test]
        public void WhenPop_IfStackIsEmpty_ShouldThrowException()
        {
            // Arrange
            var stub = new ArrayStackBaseStub<object>();

            // Act
            Action act = () => stub.Pop();

            // Assert
            act.ShouldThrowExactly<EmptyStackException>();
        }

        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void WhenSize_ShouldReturnTheCountOfElements
            ([Values(0, 1, 10, 100)] int itemsCount)
        {
            // Arrange
            var stub = new ArrayStackBaseStub<string>();
            for (var i = 0; i < itemsCount; i++)
            {
                stub.Push("Hello World!");
            }

            // Act
            var stubSize = stub.Size();

            // Assert
            Assert.AreEqual(itemsCount, stubSize);
        }
    }
}