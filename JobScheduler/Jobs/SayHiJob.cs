using System;
using FluentScheduler;

namespace JobScheduler.Jobs
{
    public class SayHiJob : IJob
    {
        public void Execute()
        {
            Console.WriteLine("Hi little parakeet!");
        }
    }
}
