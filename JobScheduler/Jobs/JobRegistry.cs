using System;
using FluentScheduler;

namespace JobScheduler.Jobs
{
    public class JobRegistry : Registry
    {
        public JobRegistry(IServiceProvider serviceProvider)
        {
            Schedule<SayHiJob>().ToRunNow().AndEvery(1).Minutes();
            Schedule(new SayHiWithDependencyJob(serviceProvider)).ToRunOnceIn(10).Seconds();
        }
    }
}
