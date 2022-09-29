namespace IdentityService.Domain
{
    //发邮件，防腐接口（学习下MailKit）
    public interface IEmailSender
    {
        public Task SendAsync(string toEmail, string subject, string body);
    }
}
