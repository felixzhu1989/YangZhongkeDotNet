using ConsoleRelation;
using Microsoft.EntityFrameworkCore;

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