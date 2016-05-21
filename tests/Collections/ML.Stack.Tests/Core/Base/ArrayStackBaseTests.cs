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

        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
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

        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
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

        /// <exception cref="InvalidStackCapacityException">If the supplied capacity is not greater than zero.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
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
    }
}