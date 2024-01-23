using System;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;

namespace netcore.template
{
    public class StepImplementation
    {
        /// <summary>
        /// This step will execute.
        /// </summary>
        [Step("Test")]
        public void Test()
        {
            var t = Task.Run(() =>
           {
               int result = DoSomethingAsync().Result;
               Console.WriteLine("Completed");
           });
            t.Wait();
        }

        /// <summary>
        /// This step will freeze.
        /// </summary>
        [Step("Test async")]
        public void TestAsync()
        {
            int result = DoSomethingAsync().Result;
            Console.WriteLine("Completed");
        }

        public async Task<int> DoSomethingAsync()
        {
            Console.WriteLine("Doing something...");
            await Task.Delay(2000);
            Console.WriteLine("Done something.");
            return 42;
        }
    }
}
