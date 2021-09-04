using Hangfire;
using Hangfire.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public class BirtdayJobManager : IBirthdateJobService
    {
        private readonly IUserService _userService;
        public BirtdayJobManager(IUserService userService)
        {
            _userService = userService;
        }
        [AutomaticRetry(Attempts = 5)]

        public void Run()
        {
            Hangfire.RecurringJob.AddOrUpdate("BirthdateJob", () => SendMail(), Cron.Minutely);
        }
        public  void SendMail()
        {
            Debug.WriteLine("Çalıştı");
            var users = _userService.GetUsers().Result;
            foreach (var user in users)
            {
                Debug.WriteLine(user.Email);
            }
        }
    }
}
