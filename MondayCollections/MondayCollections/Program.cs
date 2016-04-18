using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MondayCollections
{
    class Program
    {
        ArrayList strings;
        Stack LIFO;
        static void Main(string[] args)
        {
            Program mc = new Program();
            mc.StringAndIntegerPairs();

        }


        public void StringOrganizer()
        {
            strings = new ArrayList();
            Console.WriteLine("How many word would you like to add?:");
            int numberOfStrings = Convert.ToInt32(Console.ReadLine());

            while (numberOfStrings != 0)
            {
                Console.WriteLine("Add some text:");
                string input = Console.ReadLine();
                strings.Add(input);
                numberOfStrings--;
            }
            DisplayArrayListContent();
        }
        public void DisplayArrayListContent()
        {
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void UpdateStackWithIntegers()
        {
            LIFO = new Stack();
            Console.WriteLine("How many word would you like to add?:");
            int numberOfIntegers = Convert.ToInt32(Console.ReadLine());

            while (numberOfIntegers != 0)
            {
                Console.WriteLine("Add an integer:");
                int num = Convert.ToInt32(Console.ReadLine());
                LIFO.Push(num);
                numberOfIntegers--;
            }
            ShowStack();
        }

        public void ShowStack()
        {
            foreach (int item in LIFO)
            {
                Console.WriteLine("Integers in stack: " + item);
            }
            Console.ReadLine();
        }


        public void StringAndIntegerPairs()
        {
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            pairs["zero"] = 0;
            pairs["one"] = 1;
            pairs["two"] = 2;
            pairs["three"] = 3;
            pairs["four"] = 4;
            pairs["five"] = 5;

            string text = "Something.";
            Console.WriteLine(text);
            foreach (string item in pairs.Keys)
            {
                if (text.Contains(item))
                {
                    int value = pairs[item];
                    Console.WriteLine();
                    Console.WriteLine(text.Replace(item, value.ToString()));
                }
            }
            Console.ReadLine();

        }
    }

    class OwnGeneric<T>
    {

    }
}
