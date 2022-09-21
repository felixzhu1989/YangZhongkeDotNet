namespace ClassLibrarySimpleOnions
{
    public interface IEmailSender
    {
        public Task SendAsync(string email,string title,string body);
    }
}
