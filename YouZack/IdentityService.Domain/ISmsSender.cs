namespace IdentityService.Domain
{
    //发短信，防腐接口
    public interface ISmsSender
    {
        public Task SendAsync(string phoneNumber, params string[] args);
    }
}
