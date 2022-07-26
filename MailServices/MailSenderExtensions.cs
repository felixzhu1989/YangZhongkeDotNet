using MailServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MailSenderExtensions
    {
        public static void AddMailSender(this IServiceCollection service)
        {
            service.AddScoped<IMailSenderService, MailSenderService>();
        }
    }
}
