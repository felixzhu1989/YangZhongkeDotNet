using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityService.Domain;
using Microsoft.Extensions.Logging;

namespace IdentityService.Infrastructure.Services
{
    public class MockSmsSender:ISmsSender
    {
        private readonly ILogger<MockEmailSender> _logger;
        public MockSmsSender(ILogger<MockEmailSender> logger)
        {
            _logger = logger;
        }
        public Task SendAsync(string phoneNumber, params string[] args)
        {
            _logger.LogInformation($"Send sms to:{phoneNumber},message:{string.Join('|', args)}");
            return Task.CompletedTask;
        }
    }
}
