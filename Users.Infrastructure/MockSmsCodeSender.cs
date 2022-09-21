using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain;
using Users.Domain.ValueObject;

namespace Users.Infrastructure
{
    //模拟发送短信，真实项目可以调用各大云服务提供商的短信服务接口即可
    public class MockSmsCodeSender:ISmsCodeSender
    {
        public Task SendCodeAsync(PhoneNumber phoneNumber, string code)
        {
            Console.WriteLine($"向{phoneNumber}发送验证码：{code}");
            return Task.CompletedTask;
        }
    }
}
