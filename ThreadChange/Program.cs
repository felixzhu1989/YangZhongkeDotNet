// See https://aka.ms/new-console-template for more information

using System.Text;
Console.WriteLine($"写入大文件前的线程：{Thread.CurrentThread.ManagedThreadId}");
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++)
{
    sb.Append("xxxxxxxxxxx");
}
await File.WriteAllTextAsync(@"d:\temp\sb.txt", sb.ToString());
Console.WriteLine($"写入大文件后的线程：{Thread.CurrentThread.ManagedThreadId}");

Console.WriteLine($"计算前的线程：{Thread.CurrentThread.ManagedThreadId}");
var result= await NewCalcAsync(5000);
Console.WriteLine($"result={result}");
Console.WriteLine($"计算后的线程：{Thread.CurrentThread.ManagedThreadId}");

var s = await ReadFileAsync(1);
Console.WriteLine(s);

static async Task<decimal> CalcAsync(int n)
{
  return await Task.Run(() =>
    {
        Console.WriteLine($"CalcAsync-ThreadId:{Thread.CurrentThread.ManagedThreadId}");
        decimal result = 1;
        Random rand = new Random();
        for (int i = 0; i < n*n; i++)
        {
            result += (decimal)rand.NextDouble();
        }
        return result;
    });
}

static Task<decimal> NewCalcAsync(int n)
{
    return Task.Run(() =>
    {
        Console.WriteLine($"CalcAsync-ThreadId:{Thread.CurrentThread.ManagedThreadId}");
        decimal result = 1;
        Random rand = new Random();
        for (int i = 0; i < n*n; i++)
        {
            result += (decimal)rand.NextDouble();
        }
        return result;
    });
}


static Task<string> ReadFileAsync(int num)
{
    switch (num)
    {
        case 1:
            return File.ReadAllTextAsync(@"d:\temp\bing.txt");
        case 2:
            return File.ReadAllTextAsync(@"d:\temp\sb.txt");
        default:
            throw new ArgumentException("num invalid");
    }
}