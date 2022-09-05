namespace WebApplicationHostedService
{
    public class HostedServiceTest : BackgroundService
    {
        /*private readonly TestService _test;
        public HostedServiceTest(TestService test)
        {
            _test = test;
        }*/
        private readonly IServiceScope _scope;
        public HostedServiceTest(IServiceScopeFactory scopeFactory)
        {
            _scope=scopeFactory.CreateScope();
        }
        public override void Dispose()
        {
            _scope.Dispose();
            base.Dispose();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var test = _scope.ServiceProvider.GetRequiredService<TestService>();
            Console.WriteLine(test.Add(1, 1));
            //Console.WriteLine(_test.Add(1,1));
            Console.WriteLine("HostedServiceTest启动");
            await Task.Delay(3000, stoppingToken);//异步方法中不要用Sleep
            var file = await File.ReadAllTextAsync(@"C:\Users\felix.zhu\Desktop\Memo.txt", stoppingToken);
            Console.WriteLine("文件读取完成");
            await Task.Delay(3000, stoppingToken);
            Console.WriteLine($"输出内容：{file}");
        }
    }
}
