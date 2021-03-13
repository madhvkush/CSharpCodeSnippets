using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code1
    {
         bool SomeMethod1()
        {
            Console.WriteLine("Method 1");
            return false;
        }

         bool SomeMethod2()
        {
            Console.WriteLine("Method 2");
            return true;
        }
        public void Main()
        {
            if (SomeMethod1() & SomeMethod2())   // & --> AND  && --> AndAlso // false & True ==false
            {
                Console.WriteLine("the if block has was executed");
            }
        }
    }
}

//OutPut:- 