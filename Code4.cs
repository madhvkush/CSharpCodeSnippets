using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code4
    {
        void SomeMethod(int value)
        {
            value = 0;
        }
        void SomeMethod1(ref int value) //  variable must assigned value
        {
            value = 1;
        }
        void SomeMethod2(out int value)  // vraiable must retrun some value
        {
            value = 2;
        }

       public void Main()
        {
            int someInt;
            SomeMethod2(out someInt);
            Console.WriteLine(someInt);  // 2

            SomeMethod1(ref someInt);
            Console.WriteLine(someInt); // 1

            SomeMethod(someInt);
            Console.WriteLine(someInt); // 1

        }
    }
}
