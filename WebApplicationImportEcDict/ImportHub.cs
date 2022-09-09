using Microsoft.AspNetCore.SignalR;

namespace WebApplicationImportEcDict
{
    public class ImportHub : Hub
    {
        private readonly ImportExecutor _importExecutor;
        public ImportHub(ImportExecutor importExecutor)
        {
            _importExecutor = importExecutor;
        }

        public Task ImportEcDict()
        {
            //不等待它执行，使用下划线_（弃元）取接收
            //表示ExecuteAsync方法启动后，不等待（await）继续往下执行
            _=_importExecutor.ExecuteAsync(Context.ConnectionId);
            return Task.CompletedTask;
        }
    }
}
