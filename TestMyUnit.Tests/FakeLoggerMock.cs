namespace TestMyUnit.Tests
{
    internal class FakeLoggerMock:ILogger
    {
        public string Text;

        public void Write(string Message)
        {
            Text = Message;
        }
    }
}