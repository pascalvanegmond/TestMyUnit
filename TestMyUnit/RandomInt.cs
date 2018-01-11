using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyUnit
{
    class RandomInt
    {
        public List<int> ListOfRandomNummers = new List<int>(); 
        public int AmountOfNumbersInList = 100;
        public int NewInt;
        Random rnd = new Random();

        public void FindRandomUniqueInt()
        {
            // als de int nog niet bestaat ga verder anders, zoek verder voor een unieke int
            CreatRandomInt();
            if (CheckIfIntIsUnique(NewInt))
            {
                AddUniqueRandomIntToList();
            }
            else
            {
                FindRandomUniqueInt();
            }
        }

        public void CreatRandomInt()
        {
            // maak een random int tussen de 0 en 99999
            NewInt = rnd.Next(0, 99999);
           
        }

        public bool CheckIfIntIsUnique(int newInt)
        {
            // controleer de int met de lijst of die bestaat.
            if (ListOfRandomNummers.Contains(newInt))
                 return false;
            else
                return true;
        }

        public void AddUniqueRandomIntToList()
        {
            // voeg de nieuwe int toe aan de lijst.
            ListOfRandomNummers.Add(NewInt);
        }

        public void MakeListNDigitsLong()
        {
            // loop over N om een lijst te maken met N getallen lang.
            for (int i = 0; i < AmountOfNumbersInList; i++)
            {
                //Console.WriteLine(i);
                FindRandomUniqueInt();
            }
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
            string ListToString = string.Join(",", ListOfRandomNummers.ToArray());
            return ListToString;
        }

        public void PrintListToString()
        {
            // print de list
            Console.WriteLine(ListToString());
        }
    }
}
