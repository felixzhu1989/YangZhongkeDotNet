using Microsoft.EntityFrameworkCore;

namespace WebApplicationHostedService
{
    public class ScheduledService : BackgroundService
    {
        private readonly IServiceScope _scope;
        public ScheduledService(IServiceScopeFactory scopeFactory)
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
            try
            {
                var context = _scope.ServiceProvider.GetRequiredService<MyDbContext>();
                while (!stoppingToken.IsCancellationRequested)
                {
                    var c = await context.Users.LongCountAsync(cancellationToken: stoppingToken);
                    await System.IO.File.WriteAllTextAsync("d:/user_count.txt", c.ToString(), stoppingToken);
                    await Task.Delay(5000, stoppingToken);//每隔5秒钟执行一次循环
                    Console.WriteLine($"导出成功{DateTime.Now}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
