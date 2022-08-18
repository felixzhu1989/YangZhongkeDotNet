using ConsoleRelation;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using ConsoleRelation.ManyMany;
using ConsoleRelation.OneMany;
using ConsoleRelation.OneOne;

await using TestDbContext context = new TestDbContext();

#region 一对多数据插入和查询
/*Article a1=new Article{Title = "felix被评为读者之星",Content = "据报道。。。。"};
await context.Articles.AddAsync(a1);

Comment c1=new Comment{Message = "太牛了"};
Comment c2=new Comment{Message = "吹吧你"};
a1.Comments.Add(c1);
a1.Comments.Add(c2);

await context.SaveChangesAsync();*/

/*var a= await context.Articles.Include(a=>a.Comments).FirstOrDefaultAsync(a=>a.Id==1);
Console.WriteLine(a!.Title);
foreach (var c in a.Comments)
{
    Console.WriteLine(c.Message);
}*/

/*var c=await context.Comments.Include(c=>c.Article).FirstOrDefaultAsync(c=>c.Id==1);
Console.WriteLine(c!.Message);
Console.WriteLine(c.Article.Title);*/
#endregion

#region 优化查询
/*//var a1=await context.Articles.FirstAsync(); //生成的SQL中包含了Content
//SELECT TOP(1) [a].[Id], [a].[Content], [a].[Title] FROM[Articles] AS[a]
var a1 = await context.Articles.Select(a=>new{a.Id,a.Title}).FirstAsync();//优化查询
//SELECT TOP(1) [a].[Id], [a].[Title]FROM[Articles] AS[a]
Console.WriteLine($"id:{a1.Id},title:{a1.Title}");*/

/*var c1=await context.Comments.Select(c=>new{c.Id,AId=c.Article.Id}).FirstAsync();
// SELECT TOP(1) [c].[Id], [a].[Id] AS [AId] FROM[Comments] AS[c]
//INNER JOIN[Articles] AS [a] ON[c].[ArticleId] = [a].[Id]
Console.WriteLine($"comment Id:{c1.Id},article id:{c1.AId}");*/
/*
var c1 = await context.Comments.FirstAsync();
//SELECT TOP(1) [c].[Id], [c].[ArticleId], [c].[Message] FROM[Comments] AS[c]
Console.WriteLine($"comment Id:{c1.Id},article id:{c1.ArticleId}");
*/
#endregion

#region User
/*User u1 = new User {Name = "小峰"};
Leave l1=new Leave{Remarks = "回家处理拆迁事宜",Requester = u1};
await context.Leaves.AddAsync(l1);
await context.SaveChangesAsync();*/

/*User u2 = new User { Name = "朱总" };
User u1 =await context.Users.SingleAsync(u=>u.Name== "小峰");
Leave l1 = await context.Leaves.Where(l => l.Requester == u1).FirstAsync();
l1.Approver = u2;
await context.SaveChangesAsync();*/
#endregion

#region 自引用组织结构树

//测试自引用组织结构树
//既可以设置一个ou的Parent，也可以把节点加入父节点的Children.Add(...)
/*OrgUnit ouRoot=new OrgUnit{Name = "全球总部"};
OrgUnit ouAsia = new OrgUnit {Name = "亚洲总部"};
OrgUnit ouChina = new OrgUnit { Name = "中国分部"};
OrgUnit ouSg = new OrgUnit { Name = "新加坡分部"};
OrgUnit ouAmerica = new OrgUnit {Name = "美洲总部"};
OrgUnit ouUsa = new OrgUnit {Name = "美国分部"};
OrgUnit ouCan = new OrgUnit {Name = "加拿大分部"};
ouRoot.Children.Add(ouAsia);
ouRoot.Children.Add(ouAmerica);
ouAsia.Children.Add(ouChina);
ouAsia.Children.Add(ouSg);
ouAmerica.Children.Add(ouUsa);
ouAmerica.Children.Add(ouCan);
await context.OrgUnits.AddAsync(ouRoot);
await context.SaveChangesAsync();*/

/*OrgUnit ouRoot = new OrgUnit { Name = "全球总部" };
OrgUnit ouAsia = new OrgUnit { Name = "亚洲总部", Parent = ouRoot };
OrgUnit ouChina = new OrgUnit { Name = "中国分部", Parent = ouAsia };
OrgUnit ouSg = new OrgUnit { Name = "新加坡分部", Parent = ouAsia };
OrgUnit ouAmerica = new OrgUnit { Name = "美洲总部", Parent = ouRoot };
OrgUnit ouUsa = new OrgUnit { Name = "美国分部", Parent = ouAmerica };
OrgUnit ouCan = new OrgUnit { Name = "加拿大分部associated with this Connection which must be closed first.”
", Parent = ouAmerica };
await context.OrgUnits.AddRangeAsync(ouRoot, ouAsia, ouChina, ouSg, ouAmerica, ouUsa, ouCan);
await context.SaveChangesAsync();*/

/*//首先找到根节点，父节点为空的节点为根节点
var ouRoot = context.OrgUnits.Single(o => o.Parent == null);
Console.WriteLine(ouRoot.Name);
PrintChildren(1, ouRoot);

//测试递归缩进打印
void PrintChildren(int identLevel, OrgUnit parent)
{
    //先找到父节点的子节点
    var children = context.OrgUnits.Where(o => o.Parent == parent);
    foreach (var child in children)
    {
        Console.WriteLine(new string('\t', identLevel)+child.Name);//identLevel为\t的重复次数
        PrintChildren(identLevel++, child);//递归，打印子节点的子节点
    }
}*/
#endregion

#region 一对一数据插入
/*Order o1=new Order{Name = "书"};
Delivery d1=new Delivery {CompanyName = "峰峰快递", Number = "fengfeng0001", Order = o1};
//存Delivery才能找到Order，否则存Order找不到Delivery,如果搞不清楚关系，则全部加进去
await context.Deliveries.AddAsync(d1);
await context.SaveChangesAsync();*/
#endregion

#region 多对多
/*Student s1=new Student{Name = "张三"};
Student s2=new Student{Name = "李四"};
Student s3=new Student{Name = "王五"};
Teacher t1=new Teacher{Name = "jack"};
Teacher t2=new Teacher{Name = "tom"};
Teacher t3=new Teacher{Name = "jerry"};
s1.Teachers.Add(t1);
s1.Teachers.Add(t2);
s2.Teachers.Add(t2);
s2.Teachers.Add(t3);
s3.Teachers.Add(t1);
s3.Teachers.Add(t2);
s3.Teachers.Add(t3);
//单向添加，不要再反向添加，否则容易将关系搞混
//添加到数据库时，将实体全部加入，防止遗漏
await context.Students.AddRangeAsync(s1, s2, s3);
await context.Teachers.AddRangeAsync(t1, t2, t3);
await context.SaveChangesAsync();*/


/*//查询老师，并列出他们的学生
var teachers=context.Teachers.Include(t => t.Students);
foreach (var teacher in teachers)
{
    Console.WriteLine(teacher.Name);
    foreach (var student in teacher.Students)
    {
        Console.WriteLine($"\t{student.Name}");
    }
}*/

#endregion

#region 基于关系的复杂查询
/*//查询评论中含有”牛”的所有文章，从文章角度出发：
var items = context.Articles.Where(a => a.Comments.Any(c => c.Message.Contains("牛"))).Distinct();
foreach (var a in items)
{
    Console.WriteLine(a.Title);
}*/
/*//从评论的角度出发：
var items = context.Comments.Where(c => c.Message.Contains("牛")).Select(c => c.Article).Distinct();
foreach (var a in items)
{
    Console.WriteLine(a.Title);
}*/
/*//查询所有峰峰快递负责的订单信息
var orders= context.Orders.Where(o => o.Delivery.CompanyName == "峰峰快递");
//var orders = context.Deliveries.Where(d => d.CompanyName == "峰峰快递").Select(d => d.Order);
foreach (var order in orders)
{
    Console.WriteLine(order.Name);
}*/
#endregion

#region IQueryable

/*var items = context.Comments.Where(c => c.Message.Contains("牛"));
foreach (var c in items)
{
    Console.WriteLine(c.Message);
}*/

/*IEnumerable<Comment> comments=context.Comments;
IEnumerable<Comment> items = comments.Where(c => c.Message.Contains("牛"));
foreach (var c in items)
{
    Console.WriteLine(c.Message);
}*/
#endregion




