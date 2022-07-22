// See https://aka.ms/new-console-template for more information
//注意这里的Task并没有await，因此他们会同步进行，并不会等待
Console.WriteLine($"Task1 start:{DateTime.Now}");
Task<string> t1 = File.ReadAllTextAsync(@"d:\temp\bing.txt");
Console.WriteLine($"Task2 start:{DateTime.Now}");
Task<string> t2 = File.ReadAllTextAsync(@"d:\temp\sb.txt");
Console.WriteLine($"Task3 start:{DateTime.Now}");
Task<string> t3 = File.ReadAllTextAsync(@"d:\temp\nb.txt");
//等待上述三个任务都完成，再操作
string[] results = await Task.WhenAll(t1, t2, t3);
string s1 = results[0].Substring(0,20);
string s2 = results[1].Substring(0, 20);
string s3 = results[2].Substring(0, 20);
Console.WriteLine($"All task down:{DateTime.Now},result:\n{s1}\n{s2}\n{s3}");


string[] files= Directory.GetFiles(@"d:\temp");
Task<int>[] countTasks=new Task<int>[files.Length];//Task的集合
for (int i = 0; i < files.Length; i++)
{
    string filename=files[i];
    Task<int> t = ReadCharsCount(filename);
    countTasks[i] = t;
}

int[] counts = await Task.WhenAll(countTasks);//等所有的Task执行完成
Console.WriteLine(counts.Sum());//Linq计算数组的和


static async Task<int> ReadCharsCount(string filename)
{
    string s = await File.ReadAllTextAsync(filename);
    return s.Length;
}
interface ITest
{
    Task<int> GetCharCount(string file);
}
class Test : ITest
{
    public async Task<int> GetCharCount(string file)
    {
        var s= await File.ReadAllTextAsync(file);
        return s.Length;
    }
}