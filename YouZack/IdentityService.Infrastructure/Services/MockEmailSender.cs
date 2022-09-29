using IdentityService.Domain;
using Microsoft.Extensions.Logging;

namespace IdentityService.Infrastructure.Services
{
    public class MockEmailSender:IEmailSender
    {
        private readonly ILogger<MockEmailSender> _logger;
        public MockEmailSender(ILogger<MockEmailSender> logger)
        {
            _logger = logger;
        }
        public Task SendAsync(string toEmail, string subject, string body)
        {
            _logger.LogInformation($"Send Email to:{toEmail},title:{subject},body:{body}");
            return Task.CompletedTask;
        }
    }
}
