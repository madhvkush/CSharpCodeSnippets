using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    internal class Code12
    {
        public void Main()
        {
            string input = "2a3bc3C11d";
            var list = SplitStringByDigit(input);
            PrintData(list);
        }

        List<Item> SplitStringByDigit(string input)
        {
            List<Item> resultList = new List<Item>();

            int number = 0;
            string currentStr = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    // Store the current string if it's not empty
                    if (currentStr.Length > 0)
                    {
                        resultList.Add(new Item(number, currentStr));
                        currentStr = ""; // Reset the current string
                        number = 0; //  Reset the current number 
                    }
                    // Build the number
                    //number = int.Parse(c.ToString()); // support single-digit number only
                    number = number * 10 + int.Parse(c.ToString());  //Support multi-digit numbers
                }
                else
                {
                    currentStr += c; // Build the string
                }
            }

            // Add the last item 
            if (currentStr.Length > 0)
            {
                resultList.Add(new Item(number, currentStr));
            }
            return resultList;
        }

        void PrintData(List<Item> resultList)
        {
            foreach (Item item in resultList)
            {
                Console.WriteLine($"number={item.Number}, str={item.Str}");
            }

            foreach (Item item in resultList)
            {
                for (int i = 0; i < item.Number; i++)
                {
                    Console.Write(item.Str);
                }
            }
        }
    }

    class Item
    {
        public int Number { get; set; }
        public string Str { get; set; }

        public Item(int number, string str)
        {
            Number = number;
            Str = str;
        }
    }

}

//output = aabcbcbcCCCddddddddddd