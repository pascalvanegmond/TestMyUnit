namespace TestMyUnit
{
    class LoggerMock:ILogger
    {
        public string Text;

        public void Write(string Message)
        {
            Text = Message;
        }
    }
}
