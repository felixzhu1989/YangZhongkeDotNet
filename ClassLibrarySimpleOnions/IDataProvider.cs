namespace ClassLibrarySimpleOnions
{
    public interface IDataProvider
    {
        //返回一些待发送邮件的信息
        public IAsyncEnumerable<EmailInfo> GetEmailInfosAsync();
    }
}
