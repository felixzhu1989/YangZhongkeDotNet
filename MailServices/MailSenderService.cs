using System;
using System.Collections.Generic;
using System.Text;
using ConfigServices;
using LogServices;

namespace MailServices
{
   public class MailSenderService : IMailSenderService
    {
        private readonly ILogProvider _log;
        //private readonly IConfigService _config;
        private readonly IConfigReader _config;

        //如果真的要发邮件，MailKit是一个开源项目，主要用于收发邮件

        //从框架注入服务
        //public MailSenderService(ILogProvider log, IConfigService config)
        //改造成可覆盖的配置读取器
        public MailSenderService(ILogProvider log, IConfigReader config)
        {
            _log = log;
            _config = config;
        }

        public void Send(string title, string to, string body)
        {
            _log.LogInfo("准备发送邮件");
            var smtpServer = _config.GetValue("SmtpServer");
            var userName = _config.GetValue("UserName");
            var password = _config.GetValue("Password");
            Console.WriteLine($"邮件服务器地址{smtpServer}，名字{userName}，密码{password}");
            Console.WriteLine($"模拟发邮件{title},{to}");
            _log.LogInfo("发送邮件完成");
        }
    }
}
