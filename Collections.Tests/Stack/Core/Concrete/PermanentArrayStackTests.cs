﻿namespace Collections.Tests.Stack.Core.Concrete
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
        /// The stack is initialized with capacity (1), if second item is pushed - throw the specific exception
        /// </summary>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="InvalidStackCapacityGivenException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void StackIsInitialized_FullCapacityIsReached_IfPush_ThrowException()
        {
            // Arrange
            var stack = new PermanentArrayStack<object>(1);
            stack.Push(It.IsAny<object>());

            // Act Assert
            stack.Invoking(s => s.Push(It.IsAny<object>()))
                .ShouldThrowExactly<FullStackException>();
        }
    }
}