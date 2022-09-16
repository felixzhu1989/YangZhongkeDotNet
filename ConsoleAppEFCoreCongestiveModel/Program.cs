using ConsoleAppEFCoreCongestiveModel;
using Microsoft.EntityFrameworkCore;
using Zack.Infrastructure.EFCore;

await using var context = new MyDbContext();
/*User u1 = new User("zhf");
u1.ChangePassword("123456");
await context.Users.AddAsync(u1);
await context.SaveChangesAsync();*/

/*//手动在数据库中填写remark的值
var user= await context.Users.FirstAsync();
Console.WriteLine(user.Remark);*/

/*EntityCurrency e1=new EntityCurrency(){Name = "haha",Currency = CurrencyName.CNY};
EntityCurrency e2=new EntityCurrency(){Name = "hihi",Currency = CurrencyName.USD};
context.EntityCurrencies.Add(e1);
context.EntityCurrencies.Add(e2);
await context.SaveChangesAsync();*/

/*EntityCurrency e1 = new EntityCurrency() { Name = "heihei", Currency = CurrencyName.CNY };
EntityCurrency e2 = new EntityCurrency() { Name = "bakabaka", Currency = CurrencyName.USD };
context.EntityCurrencies.Add(e1);
context.EntityCurrencies.Add(e2);
await context.SaveChangesAsync();*/

/*foreach (var e in context.EntityCurrencies)
{
    Console.WriteLine(e.Currency);
}*/

/*Shop s = new Shop() { Name = "朱宏峰的商店", Location = new Geo(3, 5) };
context.Shops.Add(s);
await context.SaveChangesAsync();*/

/*Blog b1 = new Blog() { Title = new MultilingualString("你好", "hello"), Body = new MultilingualString("您好，在吗。", "Hello,are you ok.") };
Blog b2 = new Blog() { Title = new MultilingualString("再见", "goodbye"), Body = new MultilingualString("再见，我要回家了。", "Goodbye,I'll go home.") };
context.Blogs.Add(b1);
context.Blogs.Add(b2);
await context.SaveChangesAsync();*/

/*//拆分开来查询不符合语义
//var b = context.Blogs.First(b => b.Title.Chinese == "你好" && b.Title.English == "hello");
//更符合语义的是将title看成一个整体
//var b = context.Blogs.First(b => b.Title == new MultilingualString("你好", "hello"));
var b = context.Blogs.First(ExpressionHelper.MakeEqual((Blog b) => b.Title, new MultilingualString("你好", "hello")));
Console.WriteLine(b.Id);*/

//在外部使用时，只与实体根打交道，不直接操作Details
//Order order = new Order();
//order.AddDetail(1,1);
//context.Orders.Add(order);
//await context.SaveChangesAsync();


