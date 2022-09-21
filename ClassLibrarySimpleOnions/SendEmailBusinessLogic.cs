namespace ClassLibrarySimpleOnions
{
    public class SendEmailBusinessLogic
    {
        private readonly IEmailSender _emailSender;
        private readonly IDataProvider _dataProvider;

        public SendEmailBusinessLogic(IEmailSender emailSender, IDataProvider dataProvider)
        {
            _emailSender = emailSender;
            _dataProvider = dataProvider;
        }

        public async Task DoItAsync()
        {
            //获取数据,数据怎么来不知道，但是要求通过构造函数注入，至于实现类再那这里不管
            //所有的逻辑都是面向接口编程
            var items = _dataProvider.GetEmailInfosAsync();
            await foreach (var item in items)
            {
                //发送数据也是不需要知道实现类是什么
                await _emailSender.SendAsync(item.Email, item.Title, item.Body);
                //等待1s
                await Task.Delay(1000);
            }
        }
    }
}
