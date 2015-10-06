using System;
using System.Threading;

namespace Client.Microservice3.Service
{
    class Program
    {
        // ReSharper disable once FunctionNeverReturns
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Hello, Microservice3!");
                Thread.Sleep(1000);
            }
        }
    }
}
