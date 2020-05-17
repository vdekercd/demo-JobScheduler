using System;

namespace JobScheduler.Services
{
    public class SayHiService : ISayHiService
    {
        public void SayHi()
        {
            Console.WriteLine("Hi from depencancy.");
        }
    }
}
