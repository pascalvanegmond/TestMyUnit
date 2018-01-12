namespace TestMyUnit.Tests
{
    internal class FakeLogger:ILogMessage
    {
        public string Text;

        public void Write(string Message)
        {
            Text = Message;
        }
    }
}