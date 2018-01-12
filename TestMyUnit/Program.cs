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
            // run de applicatie en maak een lijst van 100 unieke integers.
            RandomInts randomInt = new RandomInts(new LoggerMock());
            randomInt.MakeListNDigitsLong(100);

            Console.Read();
        }

    }
}
