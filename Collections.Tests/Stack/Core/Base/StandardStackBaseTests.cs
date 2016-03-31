namespace Collections.Tests.Stack.Core.Base
{
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Core.Base;

    /// <summary>
    /// </summary>
    [TestFixture]
    public class StandardStackBaseTests
    {
        [Test]
        public void WhenItemIsPushedIntoStack_SizeMustIncrementByOne()
        {
            // Arrange
            var standardStackBaseMock = new Mock<StandardStackBase<object>>();
            var sizeBefore = standardStackBaseMock.Object.Size();

            // Act
            standardStackBaseMock.Object.Push(It.IsAny<object>());

            // Assert
            Assert.AreEqual(
                sizeBefore + 1,
                standardStackBaseMock.Object.Size(),
                "Stack size did not increment by 1 when an item was pushed inside.");
        }
    }
}