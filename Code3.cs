using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Code3
{
    class MyClassA
    {
        public MyClassA()
        {
            Console.WriteLine("constructor A");
        }

        public virtual void abc()
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

        public override void abc()
        {
            Console.WriteLine("From - B");
        }
    }
    class Code3
    {
        public void Main()
        {
            MyClassB b = new MyClassB();
            MyClassA a = b;
            a.abc();  // From-B
            Console.ReadLine();
        }
    }
}
