using IdentityService.Domain;
using IdentityService.Infrastructure.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IdentityService.Infrastructure.Services
{
    public class SendCloudEmailSender:IEmailSender
    {
        private readonly ILogger<SendCloudEmailSender> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IOptionsSnapshot<SendCloudEmailSettings> _sendCloudSettings;
        public SendCloudEmailSender(ILogger<SendCloudEmailSender> logger,IHttpClientFactory httpClientFactory,IOptionsSnapshot<SendCloudEmailSettings> sendCloudSettings)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _sendCloudSettings = sendCloudSettings;
        }
        public async Task SendAsync(string toEmail, string subject, string body)
        {
            _logger.LogInformation($"Send Email to:{toEmail},title:{subject},body:{body}");
            var postBody = new Dictionary<string, string>
            {
                ["apiUser"] = _sendCloudSettings.Value.ApiUser,
                ["apiKey"] = _sendCloudSettings.Value.ApiKey,
                ["from"] = _sendCloudSettings.Value.From,
                ["to"] = toEmail,
                ["subject"] = subject,
                ["html"] = body
            };
            using FormUrlEncodedContent httpContent = new FormUrlEncodedContent(postBody);
            var httpClient = _httpClientFactory.CreateClient();
            var responseMsg = await httpClient.PostAsync("https://api.sendcloud.net/apiv2/mail/send", httpContent);
            if (!responseMsg.IsSuccessStatusCode)
            {
                throw new Exception($"发送邮件响应码错误：{responseMsg.StatusCode}");
            }
            var respBody=await responseMsg.Content.ReadAsStringAsync();
            var respModel = respBody.ParseJson<SendCloudResponseModel>();
            if (!respModel.Result)
            {
                throw new Exception($"发送邮件响应返回失败，状态码：{respModel.StatusCode}，消息：{respModel.Message}");
            }
        }
    }
}
