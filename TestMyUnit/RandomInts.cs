using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyUnit
{
    class RandomInts
    {
        public List<int> ListOfRandomInts = new List<int>(); 
        public Random rnd = new Random();
        private ILogger log;

        public RandomInts(ILogger logger)
        {
            log = logger;
        }

        public int CreatRandomInt()
        {
            // maak een random int tussen de 0 en 99999
            var newInt = rnd.Next(0, 99999);

            return newInt;
        }

        public bool CheckIfIntIsUnique(int newInt, List<int> ListOfRandomNummers)
        {
            // controleer de int met de lijst of die bestaat.
            if (ListOfRandomNummers.Contains(newInt))
                 return false;
            else
                return true;
        }

        public void FindRandomUniqueInt()
        {
            // als de int nog niet bestaat ga verder anders, zoek verder voor een unieke int
            var newInt = CreatRandomInt();
            if (CheckIfIntIsUnique(newInt, ListOfRandomInts))
            {
                ListOfRandomInts.Add(newInt);
            }
            else
            {
                FindRandomUniqueInt();
            }
        }

        public void MakeListNDigitsLong(int n)
        {
            // loop over N om een lijst te maken met N getallen lang.
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(i);
                FindRandomUniqueInt();
            }
            log.Write("Loggin now");
            WriteListToFile();
            PrintListToString();

        }

        public void WriteListToFile()
        {
            // zorg dat de lijst geprint word in een file die output.txt heet. en in de zelfde map staat als de .exe
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                sw.Write(ListToString());
            }
        }

        public string ListToString()
        {
            // set de lijst om naar een string 
            string ListToString = string.Join(",", ListOfRandomInts.ToArray());
            return ListToString;
        }

        public void PrintListToString()
        {
            // print de list
            Console.WriteLine(ListToString());
        }
    }
}
