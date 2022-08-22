using System.Data;
using ConsoleRelation;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using ConsoleRelation.ManyMany;
using ConsoleRelation.OneMany;
using ConsoleRelation.OneOne;
using System.Diagnostics;
using Dapper;

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

#region 客户端评估
/*//默认服务器端评估
var preview= context.Comments.Select(c => new {c.Id, Pre = $"{c.Message.Substring(0, 2)}..."});
foreach (var c in preview)
{
    Console.WriteLine($"Id:{c.Id},Preview:{c.Pre}");
}*/
/*//客户端评估，将Comments强制转换成IEnumerable而不是默认的IQueryable
var preview = ((IEnumerable<Comment>)context.Comments).Select(c => new { c.Id, Pre = $"{c.Message.Substring(0, 2)}..." });
foreach (var c in preview)
{
    Console.WriteLine($"Id:{c.Id},Preview:{c.Pre}");
}*/

/*//复杂数据过滤规则，只能使用IEnumerable的Where方法才能传递本地方法
var cmts = ((IEnumerable<Comment>)context.Comments).Where(c => IsOk(c.Message));
foreach (var c in cmts)
{
    Console.WriteLine($"Id:{c.Id},Preview:{c.Message}");
}

bool IsOk(string s)
{
    //过滤规则，数据以"a"开头并且长度>5，或者不以"a"开头并且长度<3
    if (s.StartsWith("a")) return s.Length > 5;
    else return s.Length<3;
}*/

#endregion

#region IQueryable的延迟执行
/*Console.WriteLine("-----准备查询-----");
var articles=context.Articles;//构建了一个可以执行的查询，但是没有真的查询
Console.WriteLine("-----准备循环-----");
foreach (var article in articles)//遍历的时候才开始查询
{
    Console.WriteLine(article.Title);
}
Console.WriteLine("-----循环结束-----");*/

/*//分布构建IQueryable，生成了袋子查询的SQL，效率低
var arts = context.Articles.Where(a => a.Id > 1);
var arts1 = arts.Skip(2);
var arts2 = arts1.Take(3);
var arts3 = arts2.Where(a=>a.Title.Contains("微软"));
arts3.ToArray();*/
/*var arts = context.Articles.Where(a => a.Id > 1 && a.Title.Contains("微软")).Skip(2).Take(3);
arts.ToArray();*/

/*//调用动态构建IQueryable方法
QueryArticles("微软", false, false, 30);
//根据条件，动态构建IQueryable
void QueryArticles(string searchWords, bool searchAll, bool orderByPrice, double upperPrice)
{
    var arts = context.Articles.Where(a => a.Price<=upperPrice);
    //在Title和Content中都找
    if (searchAll) arts= arts.Where(a => a.Title.Contains(searchWords) || a.Content.Contains(searchWords));
    else arts= arts.Where(a => a.Title.Contains(searchWords));//只找Title
    //按照Price排序
    if (orderByPrice) arts= arts.OrderBy(a => a.Price);
    foreach (var article in arts)
    {
        Console.WriteLine(article.Title);
    }
}*/
#endregion

#region IQueryable的复用
/*var arts = context.Articles.Where(a => a.Price <= 80);
Console.WriteLine(arts.Count());
Console.WriteLine(arts.Max(a=>a.Price));
var arts2 = arts.Where(a => a.Title.Contains("微软"));
arts2.ToList();*/
#endregion

#region 分页查询
/*//取第一页，每页3条数据
PrintPage(1, 3);
//取第二页，每页3条数据
PrintPage(2, 3);

void PrintPage(int pageIndex, int pageSize)
{
    var arts = context.Articles.Where(a => !a.Title.Contains("felix"));//查询条件
    var items = arts.Skip((pageIndex - 1)*pageSize).Take(pageSize);//复用IQueryable
    foreach (var article in items)
    {
        Console.WriteLine(article.Title);
    }
    long count = arts.LongCount();//总文章数,复用IQueryable
    long pageCount = (long)Math.Ceiling(count * 1.0 / pageSize);//总页数取天花板
    Console.WriteLine($"总页数：{pageCount}");
}*/
#endregion

#region IQueryable的底层
/*//DataReader，占用数据库连接
foreach (var a in context.Articles)
{
    Console.WriteLine(a.Title);
    Thread.Sleep(100);//每遍历一条记录就停一下
}*/

/*//一次性加载到内存，程序加载时卡顿
foreach (var a in context.Articles.ToList())
{
    Console.WriteLine(a.Title);
    Thread.Sleep(100);//每遍历一条记录就停一下
}
*/

/*//调用方法里销毁DbContext时，必须要ToList或ToArray
var items = QueryNotFelix();
foreach (var article in items)
{
    Console.WriteLine(article.Title);
}

static IQueryable<Article> QueryNotFelix()
{
    using TestDbContext context2=new TestDbContext();
    return context2.Articles.Where(a=>!a.Title.Contains("felix"));
}*/

/*//嵌套循环时，DataReader被占用（连接字符串中的MultipleActiveResultSets = true删掉）
foreach (var a in context.Articles)
{
    Console.WriteLine(a.Title);
    foreach (var c in context.Comments)
    {
        Console.WriteLine(c.Message);
    }
}
*/

#endregion

#region 执行原生SQL：非查询语句
/*//@$一起使用，可以让字符串换行显示
string content = "内容待定";
await context.Database.ExecuteSqlInterpolatedAsync(
    @$"insert into Articles(Title,Content,Price)
    select Title, {content}, Price from Articles where Id<5");*/
/*//观察FormattableString
string content = "内容待定";
FormattableString sql= @$"insert into Articles(Title,Content,Price)
    select Title, {content}, Price from Articles where Id<5";
Console.WriteLine($"Format:{sql}");
Console.WriteLine($"Parameters:{string.Join(",",sql.GetArguments())}");*/

//context.Database.ExecuteSqlRawAsync()
#endregion

#region 执行原生SQL：实体查询

/*string titlePattern = "%微软%";
var arts = context.Articles.FromSqlInterpolated(
    $@"select * from Articles where Title like {titlePattern} order by newid()");
foreach (var article in arts)
{
    Console.WriteLine(article.Title);
}*/

/*//对IQureyable进一步处理
string titlePattern = "%微软%";
var arts = context.Articles.FromSqlInterpolated(
    $@"select * from Articles where Title like {titlePattern}");
foreach (var article in arts.OrderBy(a=>Guid.NewGuid()).Skip(5).Take(5))
{
    Console.WriteLine(article.Title);
}
*/
#endregion

#region 执行原生SQL：任意SQL
/*//拿到context底层的Connection对象
var conn = context.Database.GetDbConnection();
if (conn.State != ConnectionState.Open) await conn.OpenAsync();
await using var cmd=conn.CreateCommand();
cmd.CommandText = "select Price,count(*) Count from Articles group by Price";
await using var reader =await cmd.ExecuteReaderAsync();
while (await reader.ReadAsync())
{
    var price = reader.GetDouble(0);
    var count = reader.GetInt32(1);
    Console.WriteLine($"Price:{price},Count:{count}");
}*/

/*//使用Dapper执行原生SQL语句
var conn = context.Database.GetDbConnection();
var items = conn.Query<GroupByPrice>("select Price,count(*) Count from Articles group by Price");
foreach (var item in items)
{
    Console.WriteLine($"Price:{item.Price},Count:{item.Count}");
}*/
#endregion

#region 状态跟踪
/*//查看跟踪状态和跟踪信息
//修改一条，删除一条，一条不动
var items = await context.Articles.Take(3).ToArrayAsync();
var a1 = items[0];
var a2 = items[1];
var a3 = items[2];
a1.Price += 1;
context.Articles.Remove(a2);
//其中一个Add，一个不动
var a4 = new Article { Title = "a4", Content = "a4 content" ,Price = 40};
var a5 = new Article { Title = "a5", Content = "a5 content",Price = 50};
context.Articles.Add(a4);

var e1 = context.Entry(a1);
var e2 = context.Entry(a2);
var e3 = context.Entry(a3);
var e4 = context.Entry(a4);
var e5 = context.Entry(a5);
Console.WriteLine(e1.State);
Console.WriteLine(e1.DebugView.LongView);//查看变化信息
Console.WriteLine(e2.State);
Console.WriteLine(e3.State);
Console.WriteLine(e4.State);
Console.WriteLine(e5.State);*/

/*//AsNoTracking，不对实体进行跟踪
var items = await context.Articles.AsNoTracking().Take(3).ToArrayAsync();
foreach (var article in items)
{
    Console.WriteLine(article.Title);
}
var a1 = items[0];
Console.WriteLine(context.Entry(a1).State);//Detached*/

/*//先查询，然后更新
var a =await context.Articles.Where(a => a.Id == 9).SingleAsync();
a.Price = 99;
await context.SaveChangesAsync();*/

/*//剑走偏锋，直接修改
Article a = new Article { Id = 9, Price = 66 };
context.Entry(a).Property("Price").IsModified=true;
Console.WriteLine(context.Entry(a).DebugView.LongView);
context.SaveChanges();*/

/*//直接删除一条数据
Article a = new Article { Id=15};
context.Entry(a).State = EntityState.Deleted;
await context.SaveChangesAsync();*/

#endregion

#region 全局查询筛选器
/*//将id为2的数据软删除，将IsDeleted属性设置为true
var a = await context.Articles.SingleAsync(a => a.Id == 2);
a.IsDeleted = true; //实质上是更新而不是真的删除
await context.SaveChangesAsync();*/


/*foreach (var article in context.Articles.Take(3))
{
    Console.WriteLine($"ID:{article.Id},Title:{article.Title}");
}*/

/*//暂时忽略全局查询过滤器,比如做一个类似回收站的功能
foreach (var article in context.Articles.IgnoreQueryFilters().Where(a => a.IsDeleted==true))
{
    Console.WriteLine($"ID:{article.Id},Title:{article.Title}");
}*/




#endregion
