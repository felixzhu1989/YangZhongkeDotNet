using ConsoleRelation;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

await using TestDbContext context = new TestDbContext();
/*
Article a1=new Article{Title = "felix被评为读者之星",Content = "据报道。。。。"};
await context.Articles.AddAsync(a1);

Comment c1=new Comment{Message = "太牛了"};
Comment c2=new Comment{Message = "吹吧你"};
a1.Comments.Add(c1);
a1.Comments.Add(c2);

await context.SaveChangesAsync();
*/
/*
var a= await context.Articles.Include(a=>a.Comments).FirstOrDefaultAsync(a=>a.Id==1);
Console.WriteLine(a!.Title);
foreach (var c in a.Comments)
{
    Console.WriteLine(c.Message);
}
*/
/*
var c=await context.Comments.Include(c=>c.Article).FirstOrDefaultAsync(c=>c.Id==1);
Console.WriteLine(c!.Message);
Console.WriteLine(c.Article.Title);
*/
/*
//var a1=await context.Articles.FirstAsync(); //生成的SQL中包含了Content
//SELECT TOP(1) [a].[Id], [a].[Content], [a].[Title] FROM[Articles] AS[a]
var a1 = await context.Articles.Select(a=>new{a.Id,a.Title}).FirstAsync();//优化查询
//SELECT TOP(1) [a].[Id], [a].[Title]FROM[Articles] AS[a]
Console.WriteLine($"id:{a1.Id},title:{a1.Title}");
*/
/*
var c1=await context.Comments.Select(c=>new{c.Id,AId=c.Article.Id}).FirstAsync();
// SELECT TOP(1) [c].[Id], [a].[Id] AS [AId] FROM[Comments] AS[c]
//INNER JOIN[Articles] AS [a] ON[c].[ArticleId] = [a].[Id]
Console.WriteLine($"comment Id:{c1.Id},article id:{c1.AId}");
*/
/*
var c1 = await context.Comments.FirstAsync();
//SELECT TOP(1) [c].[Id], [c].[ArticleId], [c].[Message] FROM[Comments] AS[c]
Console.WriteLine($"comment Id:{c1.Id},article id:{c1.ArticleId}");
*/

/*
User u1 = new User {Name = "小峰"};
Leave l1=new Leave{Remarks = "回家处理拆迁事宜",Requester = u1};
await context.Leaves.AddAsync(l1);
await context.SaveChangesAsync();
*/
/*
User u2 = new User { Name = "朱总" };
User u1 =await context.Users.SingleAsync(u=>u.Name== "小峰");
Leave l1 = await context.Leaves.Where(l => l.Requester == u1).FirstAsync();
l1.Approver = u2;
await context.SaveChangesAsync();
*/






