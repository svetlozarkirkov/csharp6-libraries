namespace Collections.Tests.Stack.Core.Base
{
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Core.Base;

    /// <summary>
    /// </summary>
    [TestFixture]
    public class StackBaseTests
    {
        [Test]
        public void WhenItemIsPushedIntoStack_SizeMustIncrementByOne()
        {
            // Arrange
            var stackBaseMock = new Mock<StackBase<object>> {CallBase = true};
            var sizeBefore = stackBaseMock.Object.Size();

            // Act
            stackBaseMock.Object.Push(It.IsAny<object>());

            // Assert
            Assert.AreEqual(
                sizeBefore + 1,
                stackBaseMock.Object.Size(),
                "Stack size did not increment by 1 when an item was pushed inside.");
        }
    }
}