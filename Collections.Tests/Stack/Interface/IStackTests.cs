namespace Collections.Tests.Stack.Interface
{
    using Moq;
    using NUnit.Framework;
    using Collections.Stack.Interface;

    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class IStackTests
    {
        private Mock<IStack<string>> _iStackMock;

        [OneTimeSetUp]
        public void BasicSetup()
        {
            this._iStackMock = new Mock<IStack<string>>();
        }
    }
}