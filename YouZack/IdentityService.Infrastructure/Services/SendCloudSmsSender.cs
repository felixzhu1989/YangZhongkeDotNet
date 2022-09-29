using IdentityService.Domain;
using IdentityService.Infrastructure.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Zack.Commons;

namespace IdentityService.Infrastructure.Services
{
    public class SendCloudSmsSender : ISmsSender
    {
        private readonly ILogger<SendCloudSmsSender> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IOptionsSnapshot<SendCloudSmsSettings> _smsSettings;
        public SendCloudSmsSender(ILogger<SendCloudSmsSender> logger,IHttpClientFactory httpClientFactory,IOptionsSnapshot<SendCloudSmsSettings> smsSettings)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _smsSettings = smsSettings;
        }
        public async Task SendAsync(string phoneNumber, params string[] args)
        {
            _logger.LogInformation($"Send sms to:{phoneNumber},message:{string.Join('|', args)}");
            var postBody = new Dictionary<string, string>
            {
                ["smsUser"]=_smsSettings.Value.SmsUser,
                ["templateId"]="10010",
                ["phone"]=phoneNumber,
                ["vars"]=args.ToJsonString()
            };
            var signature = CalcSignature(postBody);
            postBody["signature"] = signature;
            using FormUrlEncodedContent httpContent = new FormUrlEncodedContent(postBody);
            var httpClient = _httpClientFactory.CreateClient();
            var responseMsg = await httpClient.PostAsync("http://www.sendcloud.net/smsapi/sen", httpContent);
            if (!responseMsg.IsSuccessStatusCode)
            {
                throw new ApplicationException($"发送短信响应码错误：{responseMsg.StatusCode}");
            }
            var respBody=await responseMsg.Content.ReadAsStringAsync();
            var respModel = respBody.ParseJson<SendCloudResponseModel>();
            if (!respModel.Result)
            {
                throw new ApplicationException($"发送短信失败：{respModel.Message}");
            }
        }

        private string CalcSignature(IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var smsKey = _smsSettings.Value.SmsKey;
            var orderedItems=parameters.OrderBy(x => x.Key).Select(x=>$"{x.Key}={x.Value}");
            var originParam = string.Join('&', orderedItems);
            string signStr = $"{smsKey}&{originParam}&{smsKey}";
            string signature = HashHelper.ComputeMd5Hash(signStr);
            return signature;
        }
    }
}
