using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain.ValueObject;

namespace Users.Domain
{
    //短信验证码发送
    public interface ISmsCodeSender
    {
        Task SendCodeAsync(PhoneNumber phoneNumber,string code);
    }
}
