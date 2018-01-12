using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyUnit
{
    class MockService:ILogMessage
    {
        public string Text;

        public void Write(string Message)
        {
            Text = Message;
        }
    }
}
