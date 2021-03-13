using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets
{
    class Code7
    {
        private string result;

        public void Main()
        {
            SaySomething();  // it will not wait for the return
            Console.WriteLine(result == null ? "result == null" : result);   //result == null
        }

        async Task<string> SaySomething()
        {
            await Task.Delay(5);
            //System.Threading.Thread.Sleep(5);
            result = "Hello world!";
            return "Something";
        }


    }
}
// async --> that is always called synchonously if it not have await