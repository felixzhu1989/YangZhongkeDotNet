using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySimpleOnions;

namespace ConsoleAppSimpleOnions
{
    public class MyEmailSender : IEmailSender
    {
        public Task SendAsync(string email, string title, string body)
        {
            Console.WriteLine($"假装往{email}发送邮件，标题：{title}，内容：{body}");
            return Task.CompletedTask;
        }
    }
}
