namespace Collections.Tests.Core.Base
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;
    using Collections.Core.Base;
    using Collections.Core.ExceptionHandling.Concrete;

    [TestFixture]
    public class ArrayCollectionBaseTests
    {
        /// <summary>
        /// Stub class for testing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <seealso cref="Collections.Core.Base.ArrayCollectionBase{T}" />
        private class ArrayCollectionBaseStub<T> : ArrayCollectionBase<T>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ArrayCollectionBaseStub{T}"/> class.
            /// </summary>
            /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
            internal ArrayCollectionBaseStub()
            {
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ArrayCollectionBaseStub{T}"/> class.
            /// </summary>
            /// <param name="capacity">The capacity.</param>
            /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
            internal ArrayCollectionBaseStub(int capacity) : base(capacity)
            {
            }
        }

        /// <summary>
        /// When the collection is initialized using the default parameterless constructor
        /// There should be no "Invalid Collection Capacity Exception" thrown
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void CollectionIsInitialized_UsingDefaultConstructor_ShouldNotThrowException()
        {
            // Arrange
            Action act = () => new ArrayCollectionBaseStub<object>();

            // Act Assert
            act.ShouldNotThrow<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// When the collection is initialized with an invalid capacity
        /// Should throw "Invalid Collection Capacity Exception"
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="InvalidCollectionCapacityException">The given capacity is less than or equal to zero.</exception>
        [Test]
        public void CollectionIsInitialized_InvalidCapacityGiven_ShouldThrowException(
            [Values(0, -1, -10, -100, -1000, int.MinValue)] int capacity)
        {
            // Arrange
            Action act = () => new ArrayCollectionBaseStub<object>(capacity);

            // Act Assert
            act.ShouldThrowExactly<InvalidCollectionCapacityException>();
        }
    }
}