using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code9
    {
        public static int TestValue;

        public Code9()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }
        static Code9()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }

        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine("TestValue : " + TestValue);  //10

        }
        public void Main()
        {

            Code9 t = new Code9();
            t.Print();
        }
    }

   

}
