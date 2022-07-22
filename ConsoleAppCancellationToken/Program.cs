// See https://aka.ms/new-console-template for more information


CancellationTokenSource cts = new CancellationTokenSource();
cts.CancelAfter(5000);//5秒后触发取消请求
try
{
    await Download2Async("https://www.bing.com", 200, cts.Token);
}
catch (Exception e)
{
    Console.WriteLine(e);
}

////敲击按键取消操作
//CancellationTokenSource cts = new CancellationTokenSource();
//Download2Async("https://www.bing.com", 200, cts.Token);
//while (Console.ReadLine()!="q")
//{
//}
//cts.Cancel();

static async Task DownloadAsync(string url, int n, CancellationToken cancellationToken)
{
    using HttpClient httpClient = new HttpClient();
    for (int i = 0; i < n; i++)
    {
        string content = await httpClient.GetStringAsync(url);
        Console.WriteLine($"{DateTime.Now}:{content.Substring(0,15)}");
        if (cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine("请求被取消");
            break;
        }
    }
}
static async Task Download2Async(string url, int n, CancellationToken cancellationToken)
{
    using HttpClient httpClient = new HttpClient();
    for (int i = 0; i < n; i++)
    {
        //如果相应的网站内容太大，响应时间大于设定的超时时间，则使用这种方法，以异常的形式终止执行
        var response = await httpClient.GetAsync(url, cancellationToken);
        string content =await  response.Content.ReadAsStringAsync();
        Console.WriteLine($"{DateTime.Now}:{content.Substring(0, 15)}");
    }
}

