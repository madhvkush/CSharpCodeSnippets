using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code8
    {
        delegate void Printer();
        int i = 0;
        public void Main()
        {
            List<Printer> printers = new List<Printer>();
           
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });

                //printers.Add(Print); // i m pointing a named function
            }
            // i=10 
           

            foreach (var printer in printers)
            {
                printer();  // Console.WriteLine(10); 10,10,10.. Ten times
            }
        }
        //void Print()
        //{
        //    Console.WriteLine(i); // Console.WrilteLine(i); Console.WrilteLine(i);

        
        //}
    }
}

// output:- 0,1,2...10