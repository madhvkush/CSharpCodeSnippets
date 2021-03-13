using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code6
    {
        string str;
        DateTime time;
        int intiger;
        public void Main()
        {
            Console.WriteLine(str == null ? "str == null" : str); //str == null
            Console.WriteLine(str);                               // ""
            Console.WriteLine(time == null ? "time == null" : time.ToString()); // new DateTime()
            Console.WriteLine(intiger == null ? "intiger == null" : intiger.ToString()); // 0

            Console.ReadLine();
        }
    }
}
