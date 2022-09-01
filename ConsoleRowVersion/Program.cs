//Optimistic Concurrency Control 乐观并发控制-RowVersion

using ConsoleRowVersion;
using Microsoft.EntityFrameworkCore;

await using MyDbContext context = new MyDbContext();
/*//添加一些数据
House h1 = new House { Name = "1-1-502" };
House h2 = new House { Name = "1-1-101" };
await context.Houses.AddRangeAsync(h1, h2);
await context.SaveChangesAsync();*/

//乐观并发-RowVersion
Console.WriteLine("请输入您的名字：");
string name = Console.ReadLine()!;
var h = await context.Houses.SingleAsync(h => h.Id==1);
if (!string.IsNullOrWhiteSpace(h.Owner))
{
    Console.WriteLine(h.Owner == name ? "房子已经被你抢到了" : $"房子已经被{h.Owner}占了");
    Console.ReadKey();
    return;
}
h.Owner = name;
Thread.Sleep(10000);//故意暂停10秒，模拟并发
try
{
    await context.SaveChangesAsync();
    Console.WriteLine("恭喜你，抢到了");
}
catch (DbUpdateConcurrencyException e)
{
    Console.WriteLine($"并发修改异常：{e}");
    var entry = e.Entries.First();
    var newValue = (await entry.GetDatabaseValuesAsync())!.GetValue<string>("Owner");
    Console.WriteLine($"被{newValue}抢先了");
}

Console.ReadKey();