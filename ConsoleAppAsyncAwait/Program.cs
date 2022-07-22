// See https://aka.ms/new-console-template for more information

//using HttpClient httpClient = new HttpClient();
//string content = await httpClient.GetStringAsync("https://www.bing.com");
//string destFilePath=@"d:\temp\bing.txt";
//await File.WriteAllTextAsync(destFilePath,content);
//string content2=await File.ReadAllTextAsync(destFilePath);
//Console.WriteLine(content2);

try
{
    var result = await DownLoadAsync("https://www.bing.com");
    Console.WriteLine(result.Substring(0, 200));
}
catch (Exception e)
{
    Console.WriteLine(e);
}


static async Task<string> DownLoadAsync(string url, int init = 0)
{
    try
    {
        using HttpClient httpClient = new HttpClient();
        return await httpClient.GetStringAsync(url);
    }
    catch (Exception e)
    {
        init++;
        Console.WriteLine($"retry times:{init}");
        if (init >= 3)
        {
            throw new Exception($"times out, details:{e}");
        }
        await Task.Delay(500);
        return await DownLoadAsync(url, init);
    }
}
