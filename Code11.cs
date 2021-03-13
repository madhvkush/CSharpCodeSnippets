using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    struct SampleStruct
    {
        public int i;
    }
    class Code11
    {
        public void Main()
        {
            SampleStruct x = new SampleStruct();
            SampleStruct y;
            x.i = 9;
            y = x;
            y.i = 5;
            Console.WriteLine(x.i + " " + y.i); // 9 5
        }
    }
}
