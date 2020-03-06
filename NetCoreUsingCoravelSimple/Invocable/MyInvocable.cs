using System;
using System.Threading.Tasks;
using Coravel.Invocable;

namespace NetCoreUsingCoravelSimple.Invocable
{
    public class MyInvocable : IInvocable
    {
        public Task Invoke()
        {
            Console.WriteLine(DateTime.Now.ToString("s"));

            return Task.CompletedTask;
        }
    }
}