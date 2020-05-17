using System;
using FluentScheduler;
using JobScheduler.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JobScheduler.Jobs
{
    public class SayHiWithDependencyJob : IJob
    {
        private readonly ISayHiService _sayHiService;

        public SayHiWithDependencyJob(IServiceProvider serviceProvider)
        {
            _sayHiService = serviceProvider.GetRequiredService<ISayHiService>();
        }

        public void Execute()
        {
            _sayHiService.SayHi();
        }
    }
}
