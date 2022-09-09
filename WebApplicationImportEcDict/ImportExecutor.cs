using System.Data;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;

namespace WebApplicationImportEcDict
{
    public class ImportExecutor
    {
        //注入IHubContext，向前端汇报当前进度
        private readonly IHubContext<ImportHub> _hubContext;
        public ImportExecutor(IHubContext<ImportHub> hubContext)
        {
            _hubContext = hubContext;
        }

        //前端调用执行导入
        public async Task ExecuteAsync(string connectionId)
        {
            try
            {
                await DoExecuteAsync(connectionId);
            }
            catch (Exception e)
            {
                //在前端监听异常
                await _hubContext.Clients.Client(connectionId).SendAsync("ImportFailed",e);
            }
        }


        //向当前连接的SignalRId发送消息，因此传递connectionId
        public async Task DoExecuteAsync(string connectionId)
        {
            //原本由前端上传文件，但是这里简化成直接从本地读取文件
            var lines = await File.ReadAllLinesAsync(@"C:\Users\felix.zhu\Downloads\Compressed\ECDICT-master\stardict.csv");
            var totalLines = lines.Length-1;//跳过表头

            //SqlBulkCopy（ADO.NET），定义表，定义列
            var connStr =
                "Server=PDMSERVER\\SQLEXPRESS;Database=EFCoreIdentity;User Id=sa;Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets=true";
            using var bulkCopy = new SqlBulkCopy(connStr);
            bulkCopy.DestinationTableName = "WordItems";
            bulkCopy.ColumnMappings.Add("Word", "Word");
            bulkCopy.ColumnMappings.Add("Phonetic", "Phonetic");
            bulkCopy.ColumnMappings.Add("Definition", "Definition");
            bulkCopy.ColumnMappings.Add("Translation", "Translation");

            //DataTable，定义列
            using var dataTable = new DataTable();
            dataTable.Columns.Add("Word");
            dataTable.Columns.Add("Phonetic");
            dataTable.Columns.Add("Definition");
            dataTable.Columns.Add("Translation");

            Console.WriteLine("开始导入");
            //在前端监听导入开始
            await _hubContext.Clients.Client(connectionId).SendAsync("ImportStart");

            int counter = 0;//计数器，记录当前导入的行数
            //循环填充DataTable，每100条执行一次批量插入
            foreach (var line in lines)
            {
                //简单粗暴解析csv中每一行，使用逗号分割字符串
                var strs = line.Split(',');

                var row = dataTable.NewRow();
                row["Word"] = strs[0];
                row["Phonetic"] = strs[1];
                row["Definition"] = strs[2];
                row["Translation"] = strs[3];
                dataTable.Rows.Add(row);
                counter++;
                //每满100条数据，执行一次批量插入
                if (dataTable.Rows.Count == 100)
                {
                    await bulkCopy.WriteToServerAsync(dataTable);
                    dataTable.Clear();
                }
                //通知SignalR客户端，传递总条数和当前导入进度（计数器记录的行数）
                //在前端监听导入进度
                await _hubContext.Clients.Client(connectionId).SendAsync("ImportProgress", totalLines, counter);
                Console.WriteLine($"已经导入：{counter} 条数据");
            }
            //最后一批可能不满100条，将剩下的数据执行插入
            await bulkCopy.WriteToServerAsync(dataTable);
            Console.WriteLine("导入完成");
            //在前端监听导入完成
            await _hubContext.Clients.Client(connectionId).SendAsync("ImportCompleted");
        }
    }
}
