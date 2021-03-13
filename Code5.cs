using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code5
    {
        public void Main()
        {
            goto MyLabel;
            int i = 5;
            { Console.WriteLine(i); }
        MyLabel:
            Console.WriteLine("Bye, cruel world! (=");
            //Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

//output:- Bye, cruel world! (=