using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    struct Sample
    {
        public int i;
    }
    class Code10
    {
        public void Main()
        {
            Sample x = new Sample(); // x--> value-Type  --> stack
            x.i = 10;
            fun(x);
            Console.Write(x.i + " "); // 10
        }
         void fun(Sample y)// y!=x  NO
        {
            y.i = 20; 
            Console.Write(y.i + " "); // 20
        }
    }
}
