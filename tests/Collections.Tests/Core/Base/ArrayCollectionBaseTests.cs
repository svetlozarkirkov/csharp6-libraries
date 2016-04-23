namespace Collections.Tests.Core.Base
{
    using System;
    using System.Reflection;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Collections.Core.Base;
    using Collections.Core.ExceptionHandling.Concrete;

    /// <summary>
    /// Class ArrayCollectionBaseTests.
    /// </summary>
    /// TODO Edit XML Comment Template for ArrayCollectionBaseTests
    [TestFixture]
    public class ArrayCollectionBaseTests
    {
        /// <summary>
        /// When the collection is initialized using the default parameterless constructor
        /// There should be no "Invalid Collection Capacity Exception" thrown
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void CollectionIsInitialized_UsingDefaultConstructor_ShouldNotThrowException()
        {
            // Arrange
            Action act = () => new Mock<ArrayCollectionBase<object>>() {CallBase = true};

            // Act Assert
            act.ShouldNotThrow<InvalidCollectionCapacityException>();
        }

        /// <summary>
        /// When the collection is initialized with an invalid capacity
        /// Should throw "Invalid Collection Capacity Exception"
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void CollectionIsInitialized_InvalidCapacityGiven_ShouldThrowException(
            [Values(0, -1, -10, -100, -1000, int.MinValue)] int capacity)
        {
            // Arrange
            var mock = new Mock<ArrayCollectionBase<object>>(capacity) { CallBase = true };
            object placeholder = null;
            Action act = () => { placeholder = mock.Object; };

            // Act Assert
            act.ShouldThrowExactly<TargetInvocationException>()
                .WithInnerExceptionExactly<InvalidCollectionCapacityException>();
        }
    }
}