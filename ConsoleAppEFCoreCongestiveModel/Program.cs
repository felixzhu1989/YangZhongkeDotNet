using ConsoleAppEFCoreCongestiveModel;
using Microsoft.EntityFrameworkCore;

await using var context = new MyDbContext();
/*User u1 = new User("zhf");
u1.ChangePassword("123456");
await context.Users.AddAsync(u1);
await context.SaveChangesAsync();*/

/*//手动在数据库中填写remark的值
var user= await context.Users.FirstAsync();
Console.WriteLine(user.Remark);*/



