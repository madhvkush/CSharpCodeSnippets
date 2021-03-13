using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class MyClassA
    {
        public MyClassA()
        {
            Console.WriteLine("constructor A");
        }

        public void abc()
        {
            Console.WriteLine("From - A");
        }
    }

    class MyClassB : MyClassA
    {
        public MyClassB()
        {
            Console.WriteLine("constructor B");
        }

        public void abc()  // method hiding
        {
            Console.WriteLine("From - B");
        }
    }
    class Code2
    {
        public void Main()
        {
            MyClassB b = new MyClassB();
            //b.abc(); //   From-B
            MyClassA a = b;
            a.abc();                //  From-A
            Console.ReadLine();
        }
    }
}
