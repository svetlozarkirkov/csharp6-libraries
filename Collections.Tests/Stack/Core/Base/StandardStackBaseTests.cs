namespace Collections.Tests.Stack.Core.Base
{
    using System;
    using System.Web.Script.Serialization;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Core.Base;
    using Collections.Stack.ExceptionHandling.Core.Concrete;

    [TestFixture]
    public class StandardStackBaseTests
    {
        /// <summary>
        /// When the stack is empty and an item is pushed - the size after must be '1'
        /// </summary>
        [Test]
        public void EmptyStack_WhenItemIsPushedIntoStack_SizeMustBeOne()
        {
            // Arrange
            var classMock = new Mock<StandardStackBase<object>> {CallBase = true};

            // Act
            classMock.Object.Push(It.IsAny<object>());

            // Assert
            classMock.Object.Size().Should().Be(1);
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ArgumentException">The recursion limit defined by <see cref="P:System.Web.Script.Serialization.JavaScriptSerializer.RecursionLimit" /> was exceeded. </exception>
        /// <exception cref="InvalidOperationException">The resulting JSON string exceeds the value of <see cref="P:System.Web.Script.Serialization.JavaScriptSerializer.MaxJsonLength" />. -or- <paramref name="obj" /> contains a circular reference. A circular reference occurs when a child object has a reference to a parent object, and the parent object has a reference to the child object. </exception>
        /// <exception cref="StackIndexOutOfRangeException">There is no such index in the stack.</exception>
        [Test]
        public void EmptyStack_ItemIsPushed_IndexZeroMustBeThePushedItem()
        {
            // Arrange
            var classMock = new Mock<StandardStackBase<object>>() {CallBase = true};
            var randomObject = It.IsAny<object>();
            var serializer = new JavaScriptSerializer();
            var expectedJson = serializer.Serialize(randomObject);

            // Act
            classMock.Object.Push(randomObject);
            var actualJson = serializer.Serialize(classMock.Object[0]);

            // Assert
            actualJson.ShouldBeEquivalentTo(expectedJson);

        }

        /// <summary>
        /// </summary>
        /// <exception cref="StackIndexOutOfRangeException">There is no such index in the stack.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [Test]
        public void EmptyStack_AccessAnyIndex_ShouldThrowException()
        {
            // Arrange
            var classMock = new Mock<StandardStackBase<object>> {CallBase = true};
            object test;

            // Act
            Action act = () => test = classMock.Object[It.IsAny<int>()];

            // Assert
            act.ShouldThrow<StackIndexOutOfRangeException>();
        }

        /// <summary>
        /// </summary>
        [Test]
        public void ConstructorWithCustomCapacity_InvalidCapacityGiven_ShouldThrowCapacityException()
        {

        }
    }
}