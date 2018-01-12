using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyUnit
{
    class Program
    {
        

        static void Main(string[] args)
        {

            RandomInts randomInt = new RandomInts(new LoggerMock());
            randomInt.MakeListNDigitsLong(100);

            Console.Read();
        }

    }
}
