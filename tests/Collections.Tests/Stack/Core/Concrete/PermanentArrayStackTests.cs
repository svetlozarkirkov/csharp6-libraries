namespace Collections.Tests.Stack.Core.Concrete
{
    using System;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Core.Concrete;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    [TestFixture]
    public class PermanentArrayStackTests
    {
        /// <summary>
        /// If the stack is at full capacity - "pushing" should throw specific exception
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [Test]
        public void StackIsInitialized_FullCapacityIsReached_IfPush_ThrowException(
            [Values(1, 100, 1000)] int capacity)
        {
            // Arrange
            var mock = new Mock<PermanentArrayStack<object>>(capacity) {CallBase = true};
            for (var i = 0; i < capacity; i++)
            {
                mock.Object.Push(It.IsAny<object>());
            }

            // Act Assert
            mock.Invoking(s => s.Object.Push(It.IsAny<object>()))
                .ShouldThrowExactly<FullStackException>();
        }
    }
}