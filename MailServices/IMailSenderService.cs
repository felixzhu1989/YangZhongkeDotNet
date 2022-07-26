using System;

namespace MailServices
{
    public interface IMailSenderService
    {
        void Send(string title, string to, string body);
    }
}
